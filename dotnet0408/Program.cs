// // 기본예제 5-2 Random 클래스를 사용한 임의의 살슈 샹송

// Random random = new Random();
// Console.WriteLine(random.NextDouble());
// Console.WriteLine(random.NextDouble());
// Console.WriteLine(random.NextDouble());
// Console.WriteLine(random.NextDouble());

// // 기본예제 5-3 리스트 요소 추가

// List<int> list = new List<int>();

// list.Add(52);
// list.Add(273);
// list.Add(32);
// list.Add(64);

// foreach (var item in list)
// {
//     Console.WriteLine("Count: " + list.Count + "\titem: " + item);
// }

// // 기본예제 5-4 리스트 요소 제거

// List<int> list = new List<int>() { 52, 273, 32, 64 };

// list.Remove(52);
// foreach (var item in list)
// {
//     Console.WriteLine("Count:" + list.Count + "\titem: " + item);
// }


// // 기본예제 5-5 Math 클래스 활용

// Console.WriteLine(Math.Abs(-52273));
// Console.WriteLine(Math.Ceiling(52.273));
// Console.WriteLine(Math.Floor(52.273));
// Console.WriteLine(Math.Max(52, 273));
// Console.WriteLine(Math.Min(52, 273));
// Console.WriteLine(Math.Round(52.273));

// class Program
// {
//     class Product
//     {
//         public string name;
//         public int price;
//     }

//     static void Main(string[] args)
//     {
//         Product product = new Product();

//         product.name = "감자";
//         product.price = 2000;

//         Console.WriteLine(product.name + " : " + product.price + "원");
//     }
// }

// // 기본예제 5-7 클래스 변수 생성과 사용
// class Program // main 메서드를 포함.
// {
//     class MyMath
//     {
//         public static double Pi = 3.141592;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine(MyMath.Pi);
//     }
// }

// // 기본예제 6-1 인스턴스 메서드 생성과 사용
// class Program // main 메서드를 포함
// {
//     class Test
//     {
//         public int Power(int x)
//         {
//             return x * x;
//         }
//     }

//     static void Main(string[] args)
//     {
//         Test test = new Test();
//         Console.WriteLine(test.Power(10));
//         Console.WriteLine(test.Power(20));
//     }
// }

// 1. 컴퓨터 클래스
// - 속성: 브랜드, 모델, 용도, 운영체제, 메모리 용량, 저장 용량, 화면 크기 등
// - 메서드: 켜기, 끄기, 재부팅, 프로그램 실행, 파일 저장, 인터넷 연결 등
class Computer
{
    public string brand;
    public string model;
    public string usage;
    public string os;
    public double Mstorage;
    public double storage;
    public double size;

    public void on()
    {
        Console.WriteLine("전원이 켜졌습니다.");
    }
    public void off()
    {
        Console.WriteLine("전원이 꺼졌습니다.");
    }
    public void restart()
    {
        Console.WriteLine("재부팅중...");
    }
    public void execute()
    {
        Console.WriteLine("실행 완료.");
    }
    public void save()
    {
        Console.WriteLine("저장 완료.");
    }
    public void internetConnect()
    {
        Console.WriteLine("인터넷이 연결되었습니다.");
    }
}


// 2. 주문 클래스
// - 속성: 주문번호, 주문자명, 주문일자, 주문 상품, 수량, 가격, 주소, 전화번호 등
// - 메서드: 주문 생성, 주문 취소, 결제, 배송 등
class Order
{
    public int orderNum;
    public string orderName;
    public string orderDate;
    public string orderProduct;
    public int amount;
    public double price;
    public string address;
    public string phoneNumber;

    public void makeOrder(string orderNum)
    {
        Console.WriteLine($"주문번호 : {orderNum}의 주문이 생성되었습니다.");
    }
    public void cancelOrder(string orderNum)
    {
        Console.WriteLine($"주문번호 : {orderNum}의 주문이 취소되었습니다.");
    }
    public void pay(int amount, double price)
    {
        Console.WriteLine($"총 금액 : {amount * price}를 결제해주세요.");
    }
    public void ship(string address, string phoneNumber)
    {
        Console.WriteLine($"{address} 해당 주소로 배송 예정입니다. 자세한 배송 정보는 {phoneNumber}로 안내됩니다.");
    }
}

// 3. 학생 클래스
// - 속성: 이름, 학번, 전공, 학년, 성적, 출석률, 이메일, 전화번호 등
// - 메서드: 출석 체크, 성적 입력, 성적 조회, 이메일 발송, 전화 걸기 등
class Student
{
    public string name;
    public int studentNumber;
    public string major;
    public int grade;
    public double score;
    public double attendanceRatio;
    public string email;
    public string phoneNumber;

    public void attendanceCheck(string name){ Console.WriteLine($"{name} 학생 출석 체크 되었습니다."); }
    public void inputScore(double score) 
    { 
        Console.WriteLine($"당신의 성적을 입력해주세요 : ");
        this.score = score;
    }
    public void lookUpScore(double score) { Console.WriteLine($"당신의 성적은 {score}점 입니다."); }
    public void sendEmail(string email) { Console.WriteLine($"{email} 주소로 이메일이 발송되었습니다."); }
    public void call(string phoneNumber) { Console.WriteLine($"{phoneNumber} 번호로 전화를 걸겠습니다."); }
}

// 4. 음식 주문 시스템 클래스
// - 속성: 주문번호, 주문자명, 주문일자, 주문 메뉴, 수량, 가격, 주소, 전화번호 등
// - 메서드: 메뉴 선택, 수량 입력, 가격 계산, 주문 생성, 결제, 배송 등
class OrderFood
{
    public int orderNum;
    public string orderName;
    public string orderDate;
    public string orderMenu;
    public int amount;
    public double price;
    public string address;
    public string phoneNumber;

    public void chooseMenu(string orderMenu)
    { 
        Console.WriteLine($"{orderMenu} 메뉴로 선택이 되었습니다.");
    }
    public void inputAmount(int amount)
    {
        Console.WriteLine($"{amount}개 선택 되었습니다.");
    }
    public void calcPrice(int amount, double price)
    {
        Console.WriteLine($"총 금액 {amount * price}원 입니다.");
    }
    public void makeOrder(int orderNum) 
    {
        Console.WriteLine($"{orderNum} 주문건이 생성되었습니다.");
    }
    public void pay(int amount, double price)
    {
        Console.WriteLine($"{amount * price}원 결제 요청.");
    }
    public void ship(string address, string phoneNumber)
    {
        Console.WriteLine($"{address} 해당 주소로 배송 예정입니다. 자세한 배송 정보는 {phoneNumber}로 안내됩니다.");
    }
    
}
