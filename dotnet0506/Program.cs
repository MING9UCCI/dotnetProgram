// // 7-1 전역 변수와 지역 변수
// class Program
// {
//     public static int number = 10;
//     static void Main(string[] args)
//     {
//         int number = 20;
//         Console.WriteLine(number);
//     }
// }

// // 7-2 섀도잉/하이딩(1)
// class Program
// {
//     class Parent
//     {
//         public int variable = 273;
//     }
//     class Child : Parent
//     {
//         public string variable = "shadowing"; // new 키워드 x
//     }
//     static void Main(string[] args)
//     {
//         Child child = new Child();
//         Console.WriteLine(child.variable);
//         Console.WriteLine(((Parent)child).variable);
//     }
// }

// // 7-3 섀도잉/하이딩(2)
// class Program
// {
//     class Parent
//     {
//         public void Method()
//         {
//             Console.WriteLine("부모의 메서드");
//         }
//     }
//     class Child : Parent
//     {
//         public new void Method() // new 키워드 사용
//         {
//             Console.WriteLine("자식의 메서드");
//         }
//     }
//     static void Main(string[] args)
//     {
//         Child child = new Child();
//         child.Method();
//         ((Parent)child).Method(); // 부모로 강제 형변환
//     }

// }

// // 7-4 오버라이딩
// class Program
// {
//     class Parent
//     {
//         public virtual void Method() // 가상 메서드 정의(고쳐 쓰기)
//         {
//             Console.WriteLine("부모의 메서드");
//         }
//     }
//     class Child : Parent
//     {
//         public override void Method() // 부모의 메서드를 자식의 메서드로
//         {
//             Console.WriteLine("자식의 메서드");
//         }
//     }
//     static void Main(string[] args)
//     {
//         Child child = new Child();
//         child.Method();
//         ((Parent)child).Method(); // 자식의 메서드로 덮어서 같은 결과 출력
//     }
// }

// // 7-5 오버라이딩 방지
// class Program
// {
//     class Parent
//     {
//         public virtual void Test() { }
//     }
//     class Child : Parent
//     {
//         public sealed override void Test() { }
//     }
//     class GrandChild : Child
//     {
//         // public override void Test() { } // sealed 키워드가 부모에게 있어서 더 이상 override 불가
//     }
// }

// // 7-6 추상 클래스
// class Program
// {
//     abstract class Parent
//     {
//         public void Test() { }
//     }
//     class Child : Parent
//     {
//         public void Test() { }
//     }
//     static void Main(string[] args)
//     {
//         //Parent parent = new Parent(); // 상속해서 써야하므로 객체 생성 불가
//         Child child = new Child();
//         child.Test();
//     }
// }

// // 7-7 추상 메서드
// class Program
// {
//     abstract class Parent
//     {
//         public abstract void Test(); // 추상 메서드 정의
//     }
//     class Child : Parent
//     {
//         public override void Test() { } // 오버라이딩 하지 않으면 에러 발생
//     }
// }

// 실습
class UniversityMember { }
class Student : UniversityMember { }
class Professor : UniversityMember { }
class Staff : UniversityMember { }

class Airplane { }
class Pilot : Airplane { }
class Stewardess : Airplane { }
class Passenger : Airplane { }

class Autoshop { }
class Bicycle : Autoshop { }
class Motorcycle : Autoshop { }
class Car : Autoshop { }

class Program
{
    static void Main(string[] args)
    {
        List<UniversityMember> university = new List<UniversityMember>();
        List<Airplane> airplanes = new List<Airplane>();
        List<Autoshop> autoshops = new List<Autoshop>();

        university.Add(new Student());
        university.Add(new Professor());
        university.Add(new Staff());
        airplanes.Add(new Pilot());
        airplanes.Add(new Stewardess());
        airplanes.Add(new Passenger());
        autoshops.Add(new Bicycle());
        autoshops.Add(new Motorcycle());
        autoshops.Add(new Car());

        foreach (UniversityMember m in university)
        {
            Student s = m as Student;
            if(s != null) { Console.WriteLine("학생입니다."); }

            Professor p = m as Professor;
            if(p != null) { Console.WriteLine("교수입니다."); }

            Staff st = m as Staff;
            if(st != null) { Console.WriteLine("직원입니다."); }
        }
        foreach (Airplane a in airplanes)
        {
            if (a is Pilot) { Console.WriteLine("조종사입니다."); }
            else if (a is Stewardess) { Console.WriteLine("승무원입니다."); }
            else if (a is Passenger) { Console.WriteLine("승객입니다."); }
        }
        foreach (Autoshop s in autoshops)
        {
            if (s is Bicycle) { Console.WriteLine("자전거입니다."); }
            else if (s is Motorcycle) { Console.WriteLine("오토바이입니다."); }
            else if (s is Car) { Console.WriteLine("자동차입니다."); }
        }
    }
}