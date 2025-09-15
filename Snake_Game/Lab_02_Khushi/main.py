"""
Name: Khushi kheti
Submission Code : 1242_2850_L02
Subject : Snake Game
"""

import random,sys,time,threading
from time import sleep

# Import the .NET CLR loader
import clr
# from pyqtgraph import Color

from Snake_Classes import Snake

# Now add the GDIDrawer ** NOTE : do not include .dll, it will fail, it is implied
clr.AddReference('GDIDrawer')
clr.AddReference('System.Drawing')
# Now selectively add the classes of interest, you could do
# from GDIDrawer import *
from GDIDrawer import CDrawer
from GDIDrawer import RandColor
from System.Drawing import Color

gamedelay = 0.15
running = True
key=39
mapping_keys = {'37':(-1,0), '38':(0,-1),'39':(1,0),'40':(0,1)}
mylock = threading.Lock()
max_length = 0
food_generated = False
game_snake = None

def Canvas_KeyboardEvent( bIsDown,  keyCode, dr):
    """
    Changes the key Pressed in the global variable
    :param bIsDown:
    :param keyCode:
    :param dr:
    :return:
    """
    global key, max_length,game_snake,gamedelay
    # print(keyCode)
    if not bIsDown:
        return
    if int(keyCode) == 27:
        key = 27
    if str(int(keyCode)) in mapping_keys:
        with mylock:
            key = int(keyCode)
        game_snake.grow = True
        with mylock:
            max_length += 1
    if  int(keyCode) == 187:
        if gamedelay - 0.05 > 0:
            with mylock:
                gamedelay -= 0.05

    if int(keyCode) == 189:
        with mylock:
            gamedelay += 0.05




def game_fxn(canvas_Scale = 20):
    """
    game thread for running displaying the food
    :param canvas_Scale:
    :return:
    """
    global key,running, food_generated,max_length,game_snake
    canvas = CDrawer()
    canvas.ContinuousUpdate = False
    canvas.Scale = canvas_Scale
    canvas.BBColour = Color.Green
    canvas.KeyboardEvent += Canvas_KeyboardEvent



    game_snake = Snake(random.randint(0,canvas.ScaledWidth), random.randint(0,canvas.ScaledHeight))

    while running:
        sleep(gamedelay)
        canvas.Clear()
        if not food_generated:
            food_cord = food(canvas)
        canvas.AddCenteredEllipse(food_cord[0], food_cord[1], 5, 5, Color.Red)
        head = snake_head(game_snake.tail)
        if head.x == food_cord[0] and head.y == food_cord[1]:

            game_snake.grow = True
            max_length += 1
            food_generated = False
        local_key = key  # Retreving the current global variable into local, as it  kept changing
        game_over = game_snake.GameOver(canvas)
        if local_key == 27 or game_over:
            # That's a escape key so break
            with mylock:
                running = False
            break

        canvas.AddText(f"Score : {max_length}",40,Color.Red)
        game_snake.Move(local_key)
        game_snake.Show(canvas)
        canvas.Render()

    running = False  # this was done inside as well
    canvas.Close()

def snake_head(aseg):
    """
    return the head of the snake for use
    :param aseg:
    :return:
    """
    if aseg.parent is not None:
        snake_head(aseg.parent)
    return aseg
def food(canvas):
    """
    displays the food in the cdrawer
    :param canvas:
    :return:
    """
    global food_generated
    food_generated = True
    food_x = random.randint(0,canvas.ScaledWidth)
    food_y = random.randint(0,canvas.ScaledHeight)

    return food_x,food_y

if __name__ == "__main__":
    scale = 10
    debug = False  # For changing the scale value to 100 for debugging
    if debug:
        scale = 100
    game_thread = threading.Thread(target=game_fxn, daemon=True, kwargs={'canvas_Scale':scale})
    game_thread.start()
    # game_snake = Snake(20, 20)



    now = time.time()

    while running:

        if time.time() - now >= 2:
            now = time.time()
            game_snake.grow = True
            max_length+=1
        sleep(1)



    print(f"Length of the snake is {max_length}")
    game_thread.join()



