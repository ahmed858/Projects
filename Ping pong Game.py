import turtle

window = turtle.Screen()  # intialize screen
window.title("Ping Pong Game")  # title of the window
window.bgcolor("black")  # background color
window.setup(width=800, height=600)  # set width and hieght of the window
window.tracer(0)  # stops the window from updating automtically

# madrab1
madrab1 = turtle.Turtle()
madrab1.speed(0)
madrab1.shape("square")
madrab1.color("blue")
madrab1.penup()
madrab1.goto(-350, 0)
madrab1.shapesize(stretch_wid=5, stretch_len=1)

# madrab2
madrab2 = turtle.Turtle()
madrab2.speed(0)
madrab2.shape("square")
madrab2.color("red")
madrab2.penup()
madrab2.goto(350, 0)
madrab2.shapesize(stretch_wid=5, stretch_len=1)

# ball
ball = turtle.Turtle()
ball.speed(0)
ball.shape("square")
ball.color("white")
ball.penup()
ball.goto(0, 0)
ball.dx = .3
ball.dy = .3

# functions
def madrab1_up():
    madrab1.sety(madrab1.ycor()+20)
def madrab1_down():
    madrab1.sety(madrab1.ycor()-20)
def madrab2_up():
    madrab2.sety(madrab2.ycor()+20)
def madrab2_down():
    madrab2.sety(madrab2.ycor()-20)

# Scoring
score1 = 0
score2 = 0
score = turtle.Turtle()
score.speed(0)
score.color("white")
score.penup()
score.hideturtle()
score.goto(0,260)
score.write("Player 1: "+str(score1)+" | Player 2: "+str(score2), align="center", font=("courier", 24, "normal"))


# keyboard bindings
window.listen()
window.onkey(madrab1_up, "w")
window.onkey(madrab1_down, "x")
window.onkey(madrab2_up, "Up")
window.onkey(madrab2_down, "Down")

# main game loop
while True:
    window.update()

    #move the ball
    ball.setx(ball.xcor() + ball.dx)
    ball.sety(ball.ycor() + ball.dy)

    #border check, top border 300px, bottom border -300px, ball is 20px
    if ball.ycor() > 290:
        ball.sety(290)
        ball.dy *= -1
    if ball.ycor() < -290:
        ball.sety(-290)
        ball.dy *= -1
    if ball.xcor() > 390:
        ball.goto(0, 0)
        ball.dx *= -1
        score1 += 1
        score.clear()
        score.write("Player 1: "+str(score1)+" | Player 2: "+str(score2), align="center", font=("courier", 24, "normal"))
    if ball.xcor() < -390:
        ball.goto(0, 0)
        ball.dx *= -1
        score2 += 1
        score.clear()
        score.write("Player 1: "+str(score1)+" | Player 2: "+str(score2), align="center", font=("courier", 24, "normal"))

    #TASADOM MADRAB ND BALL
    if(ball.xcor() > 340 and ball.xcor() < 350 and ( ball.ycor() < madrab2.ycor()+40 and ball.ycor() > madrab2.ycor() - 40) ):
        ball.setx(340)
        ball.dx *= -1
    if(ball.xcor() < -340 and ball.xcor() > -350 and ( ball.ycor() < madrab1.ycor()+40 and ball.ycor() > madrab1.ycor() - 40) ):
        ball.setx(-340)
        ball.dx *= -1


