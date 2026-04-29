// // 코드 6-2 두 개의 매개변수를 갖는 메서드 생성
// class Program
// {
//     class Test
//     {
//         public int Multi(int x, int y)
//         {
//             return x * y;
//         }
//     }

//     public void Main()
//     {
//         Test t = new Test();
//         Console.WriteLine(t.Multi(52, 273));
//         Console.WriteLine(t.Multi(103, 32));
//     }
// }

// // 코드 6-3 아무것도 반환하지 않는 메서드
// class Program
// {
//     class Test
//     {
//         public void Print()
//         {
//             Console.WriteLine("Print() 메서드가 호출되었습니다.");
//         }
//     }

//     static  void Main()
//     {
//         Test test = new Test();
//         test.Print();
//         test.Print();
//         test.Print();
//     }
// }


// // 기본예제 6-2 매개변수와 반환(1)
// class Program
// {
//     class Test
//     {
//         public int Sum(int min, int max)
//         {
//             int output = 0;
//             for (int i = min; i <= max; i++)
//             {
//                 output += i;
//             }
//             return output;
//         }
//     }

//     static void Main(string[] args)
//     {
//         Test t = new Test();
//         Console.WriteLine(t.Sum(1, 100));
//     }
// }

// // 기본예제 6-3 매개변수와 반환(2)
// class Program
// {    class Test
//     {    
//         public int Multiply(int min, int max)
//         {
//             int output = 1;
//             for (int i = min; i <= max; i++)
//             {
//                 output *= i;
//             }
//             return output;
//         }
//         static void Main(string[] args)
//         {
//             Test test = new Test();
//             Console.WriteLine(test.Multiply(1, 10));
//         }
//     }
// }

// // 기본예제 6-4 클래스 메서드 생성과 사용
// class Program
// {
//     class MyMath
//     {
//         public static int Abs(int input)
//         {
//             if (input < 0)
//             {
//                 return -input;
//             }
//             else
//             {
//                 return input;
//             }
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine(MyMath.Abs(52));
//             Console.WriteLine(MyMath.Abs(-273));
//         }
//     }
// }

// // 기본예제 6-5 메서드 오버로딩
// class Program
// {
//     class MyMath
//     {
//         public static int Abs(int input)
//         {
//             if (input < 0) { return -input; }
//             else { return input; }
//         }
//         public static double Abs(double input)
//         {
//             if (input < 0) { return -input; }
//             else { return input; }
//         }
//         public static long Abs(long input)
//         {
//             if (input < 0) { return -input; }
//             else { return input; }
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine(MyMath.Abs(52));
//             Console.WriteLine(MyMath.Abs(-273));

//             Console.WriteLine(MyMath.Abs(52.273));
//             Console.WriteLine(MyMath.Abs(-273.52));

//             Console.WriteLine(MyMath.Abs(52000000000));
//             Console.WriteLine(MyMath.Abs(-273000000000));
//         }
//     }
// }

// class Program
// {
//     class Product
//     {
//         public static int counter = 0;
//         public int id;
//         public string name;
//         public int price;

//         public Product(string name, int price)
//         {
//             Product.counter = counter + 1;
//             id = counter;
//             this.name = name;
//             this.price = price;
//         }

//         static void Main(string[] args)
//         {
//             Product productA = new Product("감자", 2000);
//             Product productB = new Product("고구마", 3000);

//             Console.WriteLine($"상품번호: {productA.id}, 상품명: {productA.name}, 가격: {productA.price}");
//             Console.WriteLine($"상품번호: {productB.id}, 상품명: {productB.name}, 가격: {productB.price}");
//             Console.WriteLine($"{Product.counter}개 생성되었습니다.");
//         }
//     }
// }

// class Program
// {
//     class Product
//     {
//         public string name;
//         public int price;

//         public Product(string name, int price)
//         {
//             this.name = name;
//             this.price = price;
//         }

//         ~Product()
//         {
//             Console.WriteLine($"{name}의 소멸자 호출"); 
//         }
//     }
//     static void Main(string[] args)
//     {
//         Product product = new Product("과자", 1000);
//         Console.WriteLine($"상품명: {product.name}, 가격: {product.price}");
//     }
// }

// // 기본예제 6-8 일반적인 속성
// using System.Net;

// class Program
// {
//     class Box
//     {
//         private int width;
//         public int Width
//         {
//             get { return width; }
//             set
//             {
//                 if (value > 0) { width = value; }
//                 else { Console.WriteLine("너비는 자연수를 입력해주세요."); }
//             }
//         }
        
//         private int height;
//         public int Height
//         {
//             get { return height; }
//             set
//             {
//                 if (value > 0) { height = value; }
//                 else { Console.WriteLine("높이는 자연수를 입력해주세요."); }
//             }
//         }

//         // 생성자
//         public Box(int width, int height)
//         {
//             Width = width;
//             Height = height;
//         }

//         public int Area() { return width * height; }

//         static void Main(string[] args)
//         {
//             Box box = new Box(-10, -20);
//             box.Width = -200;
//             box.Height = -100;
//         }
//     }
// }

// 실습 과제

// 1. 컴퓨터 클래스
class Computer
{
    public static int TotalCount = 0;

    private string brand = string.Empty;
    private string model = string.Empty;
    private string purpose = string.Empty;
    private string os = string.Empty;
    private int memory;
    private int storage;
    private double screenSize;
    private bool isOn;

    public string Brand { get { return brand; } set { brand = value; } }
    public string Model { get { return model; } set { model = value; } }
    public string Purpose { get { return purpose; } set { purpose = value; } }
    public string OS { get { return os; } set { os = value; } }
    public int Memory
    {
        get { return memory; }
        set { if (value > 0) memory = value; else Console.WriteLine("메모리 용량은 양수여야 합니다."); }
    }
    public int Storage
    {
        get { return storage; }
        set { if (value > 0) storage = value; else Console.WriteLine("저장 용량은 양수여야 합니다."); }
    }
    public double ScreenSize
    {
        get { return screenSize; }
        set { if (value > 0) screenSize = value; else Console.WriteLine("화면 크기는 양수여야 합니다."); }
    }
    public bool IsOn { get { return isOn; } }

    public Computer(string brand, string model, string purpose, string os, int memory, int storage, double screenSize)
    {
        Brand = brand; Model = model; Purpose = purpose; OS = os;
        Memory = memory; Storage = storage; ScreenSize = screenSize;
        isOn = false;
        TotalCount++;
    }

    public void TurnOn()
    {
        if (!isOn) { isOn = true; Console.WriteLine($"{brand} {model} 전원을 켰습니다."); }
        else Console.WriteLine("이미 켜져 있습니다.");
    }

    public void TurnOff()
    {
        if (isOn) { isOn = false; Console.WriteLine($"{brand} {model} 전원을 껐습니다."); }
        else Console.WriteLine("이미 꺼져 있습니다.");
    }

    public void Reboot()
    {
        Console.WriteLine($"{brand} {model} 재부팅 중...");
        isOn = true;
    }

    public void RunProgram(string program)
    {
        if (isOn) Console.WriteLine($"{program}을(를) 실행합니다.");
        else Console.WriteLine("컴퓨터가 꺼져 있습니다.");
    }

    public void RunProgram(string program, string[] args)
    {
        if (isOn) Console.WriteLine($"{program}을(를) 인수 [{string.Join(", ", args)}]로 실행합니다.");
        else Console.WriteLine("컴퓨터가 꺼져 있습니다.");
    }

    public void SaveFile(string filename)
    {
        Console.WriteLine($"[{brand} {model}] {filename} 파일을 기본 경로에 저장했습니다.");
    }

    public void SaveFile(string filename, string path)
    {
        Console.WriteLine($"[{brand} {model}] {filename} 파일을 {path}에 저장했습니다.");
    }

    public void ConnectInternet()
    {
        Console.WriteLine($"[{brand} {model}] 기본 네트워크에 연결합니다.");
    }

    public void ConnectInternet(string network)
    {
        Console.WriteLine($"[{brand} {model}] '{network}' 네트워크에 연결합니다.");
    }
}

// 2. 주문 클래스
class Order
{
    public static int NextOrderId = 1;

    private readonly int orderId;
    private string ordererName = string.Empty;
    private readonly DateTime orderDate;
    private string product = string.Empty;
    private int quantity;
    private int price;
    private string address = string.Empty;
    private string phone = string.Empty;
    private bool isCanceled;

    public int OrderId { get { return orderId; } }
    public string OrdererName { get { return ordererName; } set { ordererName = value; } }
    public DateTime OrderDate { get { return orderDate; } }
    public string Product { get { return product; } set { product = value; } }
    public int Quantity
    {
        get { return quantity; }
        set { if (value > 0) quantity = value; else Console.WriteLine("수량은 양수여야 합니다."); }
    }
    public int Price
    {
        get { return price; }
        set { if (value >= 0) price = value; else Console.WriteLine("가격은 0 이상이어야 합니다."); }
    }
    public string Address { get { return address; } set { address = value; } }
    public string Phone { get { return phone; } set { phone = value; } }
    public bool IsCanceled { get { return isCanceled; } }

    public Order(string ordererName, string product, int quantity, int price, string address, string phone)
    {
        orderId = NextOrderId++;
        OrdererName = ordererName;
        orderDate = DateTime.Now;
        Product = product; Quantity = quantity; Price = price;
        Address = address; Phone = phone;
        isCanceled = false;
    }

    public void Create()
    {
        Console.WriteLine($"[주문번호: {orderId}] {ordererName}님의 주문 생성 - 상품: {product}, 수량: {quantity}개");
    }

    public void Cancel()
    {
        if (!isCanceled) { isCanceled = true; Console.WriteLine($"[주문번호: {orderId}] 주문이 취소되었습니다."); }
        else Console.WriteLine("이미 취소된 주문입니다.");
    }

    public void Pay()
    {
        Console.WriteLine($"[주문번호: {orderId}] {price * quantity:N0}원 결제 완료.");
    }

    public void Pay(string method)
    {
        Console.WriteLine($"[주문번호: {orderId}] {method}으로 {price * quantity:N0}원 결제 완료.");
    }

    public void Ship()
    {
        Console.WriteLine($"[주문번호: {orderId}] 배송 시작. 주소: {address}");
    }

    public void Ship(string courier)
    {
        Console.WriteLine($"[주문번호: {orderId}] {courier}으로 배송 시작. 주소: {address}");
    }
}

// 3. 학생 클래스
class Student
{
    public static int TotalStudents = 0;

    private string name = string.Empty;
    private readonly string studentId = string.Empty;
    private string major = string.Empty;
    private int grade;
    private double gpa;
    private double attendanceRate;
    private string email = string.Empty;
    private string phone = string.Empty;

    public string Name { get { return name; } set { name = value; } }
    public string StudentId { get { return studentId; } }
    public string Major { get { return major; } set { major = value; } }
    public int Grade
    {
        get { return grade; }
        set { if (value >= 1 && value <= 4) grade = value; else Console.WriteLine("학년은 1~4 사이여야 합니다."); }
    }
    public double GPA
    {
        get { return gpa; }
        set { if (value >= 0.0 && value <= 4.5) gpa = value; else Console.WriteLine("성적은 0.0~4.5 사이여야 합니다."); }
    }
    public double AttendanceRate
    {
        get { return attendanceRate; }
        set { if (value >= 0.0 && value <= 100.0) attendanceRate = value; else Console.WriteLine("출석률은 0~100 사이여야 합니다."); }
    }
    public string Email { get { return email; } set { email = value; } }
    public string Phone { get { return phone; } set { phone = value; } }

    public Student(string name, string studentId, string major, int grade, string email, string phone)
    {
        Name = name; this.studentId = studentId; Major = major; Grade = grade;
        gpa = 0.0; attendanceRate = 0.0;
        Email = email; Phone = phone;
        TotalStudents++;
    }

    public void CheckAttendance()
    {
        attendanceRate = Math.Min(attendanceRate + 1, 100);
        Console.WriteLine($"{name} 오늘 출석 체크 완료. 출석률: {attendanceRate:F1}%");
    }

    public void CheckAttendance(DateTime date)
    {
        Console.WriteLine($"{name} {date:yyyy-MM-dd} 출석 체크 완료.");
    }

    public void EnterGrade(double newGpa)
    {
        GPA = newGpa;
        Console.WriteLine($"{name} 성적 입력 완료. GPA: {gpa}");
    }

    public void EnterGrade(string subject, double score)
    {
        Console.WriteLine($"{name} {subject} 과목 성적 입력: {score}점");
    }

    public void GetGrade()
    {
        Console.WriteLine($"{name} 전체 GPA: {gpa}");
    }

    public void GetGrade(string subject)
    {
        Console.WriteLine($"{name} {subject} 과목 성적을 조회합니다.");
    }

    public void SendEmail(string subject, string body)
    {
        Console.WriteLine($"{email}로 이메일 발송 - 제목: {subject}, 내용: {body}");
    }

    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"[발신: {email}] {to}로 이메일 발송 - 제목: {subject}, 내용: {body}");
    }

    public void Call()
    {
        Console.WriteLine($"{name}에게 {phone}으로 전화를 겁니다.");
    }

    public void Call(string message)
    {
        Console.WriteLine($"{name}에게 {phone}으로 전화합니다. 메시지: {message}");
    }
}

// 4. 음식 주문 시스템 클래스
class FoodOrderSystem
{
    public static int NextOrderId = 1;

    private readonly int orderId;
    private string ordererName = string.Empty;
    private readonly DateTime orderDate;
    private string menu = string.Empty;
    private int quantity;
    private double price;
    private string address = string.Empty;
    private string phone = string.Empty;

    public int OrderId { get { return orderId; } }
    public string OrdererName { get { return ordererName; } set { ordererName = value; } }
    public DateTime OrderDate { get { return orderDate; } }
    public string Menu { get { return menu; } set { menu = value; } }
    public int Quantity
    {
        get { return quantity; }
        set { if (value > 0) quantity = value; else Console.WriteLine("수량은 양수여야 합니다."); }
    }
    public double Price
    {
        get { return price; }
        set { if (value >= 0) price = value; else Console.WriteLine("가격은 0 이상이어야 합니다."); }
    }
    public string Address { get { return address; } set { address = value; } }
    public string Phone { get { return phone; } set { phone = value; } }

    public FoodOrderSystem(string ordererName, string address, string phone)
    {
        orderId = NextOrderId++;
        OrdererName = ordererName;
        orderDate = DateTime.Now;
        menu = ""; quantity = 0; price = 0;
        Address = address; Phone = phone;
    }

    public void SelectMenu(string menuName)
    {
        menu = menuName;
        Console.WriteLine($"메뉴 선택: {menu}");
    }

    public void SelectMenu(string menuName, int qty)
    {
        menu = menuName;
        Quantity = qty;
        Console.WriteLine($"메뉴 선택: {menu}, 수량: {quantity}개");
    }

    public void EnterQuantity(int qty)
    {
        Quantity = qty;
        Console.WriteLine($"수량 입력: {quantity}개");
    }

    public void EnterQuantity(string menuName, int qty)
    {
        menu = menuName;
        Quantity = qty;
        Console.WriteLine($"{menu} 수량 입력: {quantity}개");
    }

    public double CalculatePrice()
    {
        double total = price * quantity;
        Console.WriteLine($"총 가격: {total:N0}원");
        return total;
    }

    public double CalculatePrice(double discount)
    {
        double total = price * quantity * (1 - discount);
        Console.WriteLine($"할인 {discount * 100}% 적용 후 총 가격: {total:N0}원");
        return total;
    }

    public void CreateOrder()
    {
        Console.WriteLine($"[주문번호: {orderId}] {ordererName}님 음식 주문 생성 - 메뉴: {menu}, 수량: {quantity}개");
    }

    public void Pay()
    {
        Console.WriteLine($"[주문번호: {orderId}] {price * quantity:N0}원 결제 완료.");
    }

    public void Pay(string method)
    {
        Console.WriteLine($"[주문번호: {orderId}] {method}으로 {price * quantity:N0}원 결제 완료.");
    }

    public void Deliver()
    {
        Console.WriteLine($"[주문번호: {orderId}] 음식이 {address}로 배달 중입니다.");
    }

    public void Deliver(string deliveryAddress)
    {
        Console.WriteLine($"[주문번호: {orderId}] 음식이 {deliveryAddress}로 배달 중입니다.");
    }
}

