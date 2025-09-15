
import clr
clr.AddReference('GDIDrawer')

from GDIDrawer import CDrawer
from GDIDrawer import RandColor
from System.Drawing import Color
class Segment:
    """
    Left 37
    Up 38
    Right 39
    Down 40
    """
    mapping_keys = {37:(-1,0), 38:(0,-1),39:(1,0),40:(0,1)}
    def __init__(self,x,y, col,parent ):
        self.x = x
        self.y = y
        self.col = col
        self.parent = parent

    def __eq__(self, other):
        return self.x == self.y

    def Show(self,canvas):
        """
        Displys the snake
        :param canvas:
        :return:
        """
        canvas.AddCenteredEllipse(self.x, self.y, 5, 5, self.col)
        if self.parent is None:
            canvas.AddCenteredEllipse(self.x+1, self.y, 1, 1, Color.Black)
            canvas.AddCenteredEllipse(self.x -1, self.y, 1, 1, Color.Black)
            canvas.AddLine(self.x+1, self.y+2,self.x, self.y+2,Color.Red,5)
            return
        self.parent.Show(canvas)

    def Move(self, akey_code):
        """
        MOves the snake's head in the direction
        :param akey_code:
        :return:
        """
        direction = Segment.mapping_keys[akey_code]
        if self.parent is None:
            #This is the head and suppose to move in the direction
            self.x += direction[0]
            self.y += direction[1]
            return
        self.stored_x = self.parent.x
        self.stored_y = self.parent.y

        self.parent.Move(akey_code)
        self.x = self.stored_x
        self.y = self.stored_y


class Snake:

    def __init__(self,x,y):
        self.x = x
        self.y = y
        self.tail = Segment(x,y,RandColor.GetColor(),None)
        self.grow = True

    def Show(self, canvas):
        self.tail.Show(canvas)


    def Move(self,keycode):
        curr_tail = None
        if self.grow:
            curr_tail_x = self.tail.x
            curr_tail_y = self.tail.y
            self.tail = Segment(curr_tail_x, curr_tail_y, RandColor.GetColor(), self.tail)
            self.grow = False

        self.tail.Move(keycode)

    def GameOver(self, canvas):
        """
        Checks if the snake has broken any rules
        :param canvas:
        :return:
        """
        width = canvas.ScaledWidth
        height = canvas.ScaledHeight

        # Get head (segment without parent)
        head = self.tail
        while head.parent is not None:
            head = head.parent

        # Check for wall collision
        if head.x < 0 or head.x >= width or head.y < 0 or head.y >= height:
            return True

        # Check for self-collision
        segment = self.tail
        while segment.parent is not None:
            if segment.x == head.x and segment.y == head.y:
                return True
            segment = segment.parent

        return False







