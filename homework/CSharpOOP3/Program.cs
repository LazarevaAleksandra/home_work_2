using CSharpOOP3;

string name = "Ball";
double radius = 5;
Ball ball = new Ball(name, radius);

ball.GetShape();

string name1 = "Pyramid";
double height2 = 7;
double s = 20;
Pyramid pyramid = new Pyramid(name1, height2, s);

pyramid.GetShape();

string name2 = "Cylinder";
double radius2 = 7;
double height3 = 10;
Cylinder cylinder = new Cylinder(name2, height3, radius2);

cylinder.GetShape();

Student student = new Student();
student.Name = "Alex";
student.Age = 20;

student.InfoOfStudent();




