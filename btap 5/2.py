from turtle import *
def draw_star(x,y,length):
    penup()
    goto(x,y)
    pendown()
    for i in range(5):
        forward (length)
        right (144)
##draw_star(10,20,30)
speed(0)
color('blue')
for i in range(100):
    import random
    x = random.randint(-300, 300)
    y = random.randint(-300, 300)
    length = random.randint(3, 10)
    draw_star(x, y, length)

# ham random toa do do dai va length nen ra ngau hung cac ngoi sao
