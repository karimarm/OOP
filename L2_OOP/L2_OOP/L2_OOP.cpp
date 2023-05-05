#include <iostream>
#include <stdarg.h>

using namespace std;


class Point {
protected:
	int coordX, coordY;
public:
	void GetCoord();

	Point() {
		coordX = 0;
		coordY = 0;
		cout << "Point()"; GetCoord();
	}
	Point(int x, int y) {
		coordX = x;
		coordY = y;
		cout << "Point(int x, int y)"; GetCoord();
	}
	Point(Point& p) {
		this->coordX = p.coordX;
		this->coordY = p.coordY;
		cout << "Point(Point& p)"; GetCoord();
	}
	~Point() {
		cout << "~Point(): "; GetCoord();
	}
};
void Point::GetCoord() {
	cout << "(" << this->coordX << "; " << this->coordY << ")\n";
}


class Rectangle {
protected:
	Point* p1;
	Point* p2;
public:
	Rectangle() {
		cout << "Rectangle()\n";
		p1 = new Point;
		p2 = new Point;
	}
	Rectangle(int x1, int y1, int x2, int y2) {
		cout << "Rectangle(int x1, int y1, int x2, int y2)\n";
		p1 = new Point(x1, y1);
		p2 = new Point(x2, y2);
	}
	Rectangle(Point& p1, Point& p2) {
		cout << "Rectangle(Point p1, Point p2)\n";
		this->p1 = new Point(p1);
		this->p2 = new Point(p2);
	}
	Rectangle(Rectangle& rec) {
		cout << "Rectangle(Rectangle& rec)\n";
		this->p1 = new Point(*rec.p1);
		this->p2 = new Point(*rec.p2);
	}
	~Rectangle() {
		cout << "~Rectangle()\n";
		delete p1;
		delete p2;
	}
};


class Triangle : public Rectangle {
protected:
	Point* p3;
public:
	Triangle() :Rectangle() {
		cout << "Triangle()\n";
		p3 = new Point;
	}
	Triangle(int x1, int y1, int x2, int y2, int x3, int y3) :Rectangle(x1, y1, x2, y2) {
		cout << "Triangle(int x1, int y1, int x2, int y2, int x3, int y3)\n";
		p3 = new Point(x3, y3);
	}
	Triangle(Point& p1, Point& p2, Point& p3) :Rectangle(p1, p2) {
		cout << "Triangle(Point p1, Point p2, Point& p3)\n";
		this->p3 = new Point(p3);
	}
	Triangle(Triangle& rec) :Rectangle() {
		cout << "Triangle(Triangle& rec)\n";
		this->p1 = new Point(*rec.p1);
		this->p2 = new Point(*rec.p2);
		this->p3 = new Point(*rec.p3);
	}
	~Triangle() {
		cout << "~Triangle()\n";
		delete p3;
	}
};


class Polygon {
protected:
	int n;
	Point** p;
public:
	Polygon() {
		cout << "Polygon()\n";
		n=0;
	}
	Polygon(int n, ...) {
		cout << "Polygon(int n, ...)\n";
		this->n = n;
		p = new Point*[n];
		va_list points;
		va_start(points, n);
		for (int i = 0; i < n; i++)
			p[i] = new Point(va_arg(points, Point));
		va_end(points);
	}
	Polygon(Polygon& pl) {
		cout << "Poligon(Polygon& pl)\n";
		this->n = pl.n;
		p = new Point * [n];
		for (int i = 0; i < n; i++)
			p[i] = new Point(*pl.p[i]);
	}
	~Polygon() {
		cout << "~Polygon():\n";
	}
};



int main()
{
	setlocale(LC_ALL, "RU");
	{
		cout << "Статическое определение точек:\n";
		Point a;
		Point b(1, 2);
		Point c(b);	
	}

	{
		cout << "\nДинамическое определение точек:\n";
		Point* a = new Point;
		Point* b = new Point(1, 2);
		Point* c = new Point(*b);

		delete a;
		delete b;
		delete c;
	}

	{
		cout << "\nСтатическое определение прямоугольников:\n";
		Point a(10, 20);
		Point b(30, 40);
		Rectangle rec1;
		Rectangle rec2(1, 2, 3, 4);
		Rectangle rec3(a, b);
		Rectangle rec4(rec2);
	}

	{
		cout << "\nДинамическое определенеие прямоугольников:\n";
		Point* a = new Point(10, 20);
		Point* b = new Point(30, 40);
		Rectangle* rec1 = new Rectangle;
		Rectangle* rec2 = new Rectangle(1, 2, 3, 4);
		Rectangle* rec3 = new Rectangle(*a, *b);
		Rectangle* rec4 = new Rectangle(*rec2);

		delete a;
		delete b;
		delete rec1;
		delete rec2;
		delete rec3;
		delete rec4;
	}

	{
		cout << "\nОпределение треугольниеов:\n";
		Point a(10, 20);
		Point b(30, 40);
		Point c(50, 60);
		Triangle d;
		Triangle* e = new Triangle(1, 2, 3, 4, 5, 6);
		Triangle* f = new Triangle(a, b, c);
		Rectangle* g = new Triangle();

		delete e;
		delete f;
		delete g;
	}

	{
		cout << "\nМногоугольник:\n";
		Point p1;
		Point p2(1, 2);
		Point* p3 = new Point(3, 4);
		Polygon z;
		Polygon a(4, p1, p2, *p3, *new Point(5, 6));
		Polygon b(a);
		delete p3;
	}

	return 0;
}