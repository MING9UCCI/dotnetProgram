// // 7-4 부모 클래스 정의
// class Animal
// {
//     public int Age { get; set; }
//     public Animal() { this.Age = 0;}
//     public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
//     public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
// }

// class Dog : Animal
// {
//     public string Color { get; set; }
//     public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
// }

// class Cat : Animal
// {
//     public void Meow() { Console.WriteLine("냥냥 웁니다."); }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Animal> Animals = new List<Animal>
//         {
//             new Dog(), new Cat(), new Cat(), new Dog(),
//             new Dog(), new Cat(), new Dog(), new Dog()
//         };
//         foreach (var item in Animals)
//         {
//             item.Eat();
//             item.Sleep();

//             var dog = item as Dog;
//             if (dog != null) { dog.Bark(); }

//             var cat = item as Cat;
//             if (cat != null) { cat.Meow(); } 
//         }
//     }
// }


class UniversityMember
{
    public string Name { get; set; }
    public int Age { get; set; }
    public UniversityMember(string name)
    {
        this.Name = name;
    }
    public UniversityMember(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"안녕하세요 저는 {Name}이고, 나이는 {Age}입니다.");
    }
    public void ShowInfo()
    {
        Console.WriteLine("대학교 소속입니다.");
    }
}
class Student : UniversityMember
{
    public string StudentID { get; set; }
    public Student(string name, int age, string studentid)
    : base(name, age)   
    {
        this.StudentID = studentid;
    }
    public override void Introduce()
    {
        Console.WriteLine($"안녕하세요 제 이름은 {Name}이고, 나이는 {Age}입니다. (StudentID : {StudentID})");
    }
}
class Professor : UniversityMember
{
    public string ProfessorID { get; set; }
    public Professor(string name, int age, string professorid)
    : base(name, age)   
    {
        this.ProfessorID = professorid;
    }
    public override void Introduce()
    {
        Console.WriteLine($"안녕하세요 제 이름은 {Name}이고, 나이는 {Age}입니다. (ProfessorID : {ProfessorID})");
    }
}
class Staff : UniversityMember
{
    public string StaffID { get; set; }
    public Staff(string name, int age, string staffid)
    : base(name, age)   
    {
        this.StaffID = staffid;
    }
    public override void Introduce()
    {
        Console.WriteLine($"안녕하세요 제 이름은 {Name}이고, 나이는 {Age}입니다. (StaffID : {StaffID})");
    }
    public new void ShowInfo()
    {
        Console.WriteLine("스태프입니다.");
    }
}

class AutoMall
{
    public string Brand { get; set; }
    public double Price { get; set; }
    public AutoMall(string brand)
    {
        this.Brand = brand;
    }
    public AutoMall(string brand, double price)
    {
        this.Brand = brand;
        this.Price = price;
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"브랜드: {Brand}, 가격: {Price}원");
    }
    public void ShowInfo()
    {
        Console.WriteLine("오토 쇼핑몰 상품입니다.");
    }
}
class Bicycle : AutoMall
{
    public int Gears { get; set; }
    public Bicycle(string brand, double price, int gears)
    : base(brand, price)
    {
        this.Gears = gears;
    }
    public override void Introduce()
    {
        Console.WriteLine($"[자전거] 브랜드: {Brand}, 가격: {Price}원, 기어수: {Gears}단");
    }
    public new void ShowInfo()
    {
        Console.WriteLine("자전거입니다.");
    }
}
class Motorcycle : AutoMall
{
    public int CC { get; set; }
    public Motorcycle(string brand, double price, int cc)
    : base(brand, price)
    {
        this.CC = cc;
    }
    public override void Introduce()
    {
        Console.WriteLine($"[오토바이] 브랜드: {Brand}, 가격: {Price}원, 배기량: {CC}cc");
    }
}
class Car : AutoMall
{
    public int Seats { get; set; }
    public Car(string brand, double price, int seats)
    : base(brand, price)
    {
        this.Seats = seats;
    }
    public override void Introduce()
    {
        Console.WriteLine($"[자동차] 브랜드: {Brand}, 가격: {Price}원, 좌석수: {Seats}석");
    }
}

abstract class BroadcastProgram
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public BroadcastProgram(string title, int duration)
    {
        this.Title = title;
        this.Duration = duration;
    }
    public abstract void Play();
    public abstract void ShowInfo();
}
class Movie : BroadcastProgram
{
    public string Director { get; set; }
    public Movie(string title, int duration, string director)
    : base(title, duration)
    {
        this.Director = director;
    }
    public override void Play()
    {
        Console.WriteLine($"[영화] {Title} 재생중... (감독: {Director})");
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"영화 제목: {Title}, 상영시간: {Duration}분, 감독: {Director}");
    }
}
class News : BroadcastProgram
{
    public string Channel { get; set; }
    public News(string title, int duration, string channel)
    : base(title, duration)
    {
        this.Channel = channel;
    }
    public override void Play()
    {
        Console.WriteLine($"[뉴스] {Title} 방송중... (채널: {Channel})");
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"뉴스 제목: {Title}, 방송시간: {Duration}분, 채널: {Channel}");
    }
}
class Drama : BroadcastProgram
{
    public int Episodes { get; set; }
    public Drama(string title, int duration, int episodes)
    : base(title, duration)
    {
        this.Episodes = episodes;
    }
    public override void Play()
    {
        Console.WriteLine($"[드라마] {Title} 재생중... (총 {Episodes}화)");
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"드라마 제목: {Title}, 회당시간: {Duration}분, 총화수: {Episodes}화");
    }
}

abstract class Shape
{
    public string Color { get; set; }
    public Shape(string color)
    {
        this.Color = color;
    }
    public abstract double GetArea();
    public abstract void Draw();
}
class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public Triangle(string color, double b, double h)
    : base(color)
    {
        this.Base = b;
        this.Height = h;
    }
    public override double GetArea()
    {
        return 0.5 * Base * Height;
    }
    public override void Draw()
    {
        Console.WriteLine($"[삼각형] 색상: {Color}, 넓이: {GetArea()}");
    }
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(string color, double width, double height)
    : base(color)
    {
        this.Width = width;
        this.Height = height;
    }
    public override double GetArea()
    {
        return Width * Height;
    }
    public override void Draw()
    {
        Console.WriteLine($"[사각형] 색상: {Color}, 넓이: {GetArea()}");
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(string color, double radius)
    : base(color)
    {
        this.Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override void Draw()
    {
        Console.WriteLine($"[원] 색상: {Color}, 넓이: {GetArea():F2}");
    }
}