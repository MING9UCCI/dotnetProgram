class Computer
{
    private string brand;
    private string model;
    private string purpose;
    private string os;
    private int memory;
    private int storage;
    private double screenSize;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string Purpose
    {
        get { return purpose; }
        set { purpose = value; }
    }
    public string OS
    {
        get { return os; }
        set { os = value; }
    }
    public int Memory
    {
        get { return memory; }
        set { memory = value < 0 ? 0 : value; }
    }
    public int Storage
    {
        get { return storage; }
        set { storage = value < 0 ? 0 : value; }
    }
    public double ScreenSize
    {
        get { return screenSize; }
        set { screenSize = value < 0 ? 0 : value; }
    }

    public Computer()
    {
        this.brand = "";
        this.model = "";
        this.purpose = "";
        this.os = "";
    }
    public Computer(string brand)
    {
        this.brand = brand;
        this.model = "";
        this.purpose = "";
        this.os = "";
    }
    public Computer(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
        this.purpose = "";
        this.os = "";
    }
    public Computer(string brand, string model, string purpose, string os, int memory, int storage, double screenSize)
    {
        this.brand = brand;
        this.model = model;
        this.purpose = purpose;
        this.os = os;
        this.memory = memory < 0 ? 0 : memory;
        this.storage = storage < 0 ? 0 : storage;
        this.screenSize = screenSize < 0 ? 0 : screenSize;
    }

    public void TurnOn() { Console.WriteLine($"{brand} 켜짐"); }
    public void TurnOff() { Console.WriteLine($"{brand} 꺼짐"); }
    public void Reboot() { Console.WriteLine($"{brand} 재부팅"); }
    public void RunProgram(string program) { Console.WriteLine($"{program} 실행"); }
    public void SaveFile(string file) { Console.WriteLine($"{file} 저장"); }
    public void ConnectInternet() { Console.WriteLine("인터넷 연결"); }
}

class Order
{
    private int orderId;
    private string customerName;
    private string orderDate;
    private string product;
    private int quantity;
    private int price;
    private string address;
    private string phone;

    public int OrderId
    {
        get { return orderId; }
        set { orderId = value < 0 ? 0 : value; }
    }
    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }
    public string OrderDate
    {
        get { return orderDate; }
        set { orderDate = value; }
    }
    public string Product
    {
        get { return product; }
        set { product = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value < 0 ? 0 : value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value < 0 ? 0 : value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public Order()
    {
        this.customerName = "";
        this.orderDate = "";
        this.product = "";
        this.address = "";
        this.phone = "";
    }
    public Order(int orderId)
    {
        this.orderId = orderId < 0 ? 0 : orderId;
        this.customerName = "";
        this.orderDate = "";
        this.product = "";
        this.address = "";
        this.phone = "";
    }
    public Order(int orderId, string customerName)
    {
        this.orderId = orderId < 0 ? 0 : orderId;
        this.customerName = customerName;
        this.orderDate = "";
        this.product = "";
        this.address = "";
        this.phone = "";
    }
    public Order(int orderId, string customerName, string orderDate, string product, int quantity, int price, string address, string phone)
    {
        this.orderId = orderId < 0 ? 0 : orderId;
        this.customerName = customerName;
        this.orderDate = orderDate;
        this.product = product;
        this.quantity = quantity < 0 ? 0 : quantity;
        this.price = price < 0 ? 0 : price;
        this.address = address;
        this.phone = phone;
    }

    public void CreateOrder() { Console.WriteLine($"주문 {orderId} 생성"); }
    public void CancelOrder() { Console.WriteLine($"주문 {orderId} 취소"); }
    public void Pay() { Console.WriteLine($"결제 완료: {price * quantity}원"); }
    public void Deliver() { Console.WriteLine($"{address}로 배송 시작"); }
}

class Student
{
    private string name;
    private int studentId;
    private string major;
    private int grade;
    private double gpa;
    private double attendanceRate;
    private string email;
    private string phone;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int StudentId
    {
        get { return studentId; }
        set { studentId = value < 0 ? 0 : value; }
    }
    public string Major
    {
        get { return major; }
        set { major = value; }
    }
    public int Grade
    {
        get { return grade; }
        set { grade = value < 1 ? 1 : value; }
    }
    public double GPA
    {
        get { return gpa; }
        set { gpa = value < 0 ? 0 : value; }
    }
    public double AttendanceRate
    {
        get { return attendanceRate; }
        set { attendanceRate = value < 0 ? 0 : value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public Student()
    {
        this.name = "";
        this.major = "";
        this.email = "";
        this.phone = "";
    }
    public Student(string name)
    {
        this.name = name;
        this.major = "";
        this.email = "";
        this.phone = "";
    }
    public Student(string name, int studentId)
    {
        this.name = name;
        this.studentId = studentId < 0 ? 0 : studentId;
        this.major = "";
        this.email = "";
        this.phone = "";
    }
    public Student(string name, int studentId, string major, int grade, double gpa, double attendanceRate, string email, string phone)
    {
        this.name = name;
        this.studentId = studentId < 0 ? 0 : studentId;
        this.major = major;
        this.grade = grade < 1 ? 1 : grade;
        this.gpa = gpa < 0 ? 0 : gpa;
        this.attendanceRate = attendanceRate < 0 ? 0 : attendanceRate;
        this.email = email;
        this.phone = phone;
    }

    public void CheckAttendance() { Console.WriteLine($"{name} 출석 체크"); }
    public void InputGrade(double gpa) { this.gpa = gpa < 0 ? 0 : gpa; Console.WriteLine($"성적 입력: {this.gpa}"); }
    public void CheckGrade() { Console.WriteLine($"{name} 성적: {gpa}"); }
    public void SendEmail() { Console.WriteLine($"{email}로 이메일 발송"); }
    public void Call() { Console.WriteLine($"{phone}로 전화"); }
}

class OrderFood
{
    private int orderId;
    private string customerName;
    private string orderDate;
    private string menu;
    private int quantity;
    private int price;
    private string address;
    private string phone;

    public int OrderId
    {
        get { return orderId; }
        set { orderId = value < 0 ? 0 : value; }
    }
    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }
    public string OrderDate
    {
        get { return orderDate; }
        set { orderDate = value; }
    }
    public string Menu
    {
        get { return menu; }
        set { menu = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value < 0 ? 0 : value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value < 0 ? 0 : value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public OrderFood()
    {
        this.customerName = "";
        this.orderDate = "";
        this.menu = "";
        this.address = "";
        this.phone = "";
    }
    public OrderFood(int orderId)
    {
        this.orderId = orderId < 0 ? 0 : orderId;
        this.customerName = "";
        this.orderDate = "";
        this.menu = "";
        this.address = "";
        this.phone = "";
    }
    public OrderFood(int orderId, string customerName)
    {
        this.orderId = orderId < 0 ? 0 : orderId;
        this.customerName = customerName;
        this.orderDate = "";
        this.menu = "";
        this.address = "";
        this.phone = "";
    }
    public OrderFood(int orderId, string customerName, string orderDate, string menu, int quantity, int price, string address, string phone)
    {
        this.orderId = orderId < 0 ? 0 : orderId;
        this.customerName = customerName;
        this.orderDate = orderDate;
        this.menu = menu;
        this.quantity = quantity < 0 ? 0 : quantity;
        this.price = price < 0 ? 0 : price;
        this.address = address;
        this.phone = phone;
    }

    public void SelectMenu(string menu) { this.menu = menu; Console.WriteLine($"메뉴 선택: {this.menu}"); }
    public void InputQuantity(int qty) { this.quantity = qty < 0 ? 0 : qty; Console.WriteLine($"수량: {this.quantity}"); }
    public void CalcPrice() { Console.WriteLine($"총 가격: {price * quantity}원"); }
    public void CreateOrder() { Console.WriteLine($"주문 {orderId} 생성"); }
    public void Pay() { Console.WriteLine($"결제 완료"); }
    public void Deliver() { Console.WriteLine($"{address}로 배달"); }
}

class Program
{
    static void ChangeBrand(Computer c) { c.Brand = "LG"; }
    static void ScaleMemory(int memory) { memory = 999; }

    static void ChangeOwner(Order o) { o.CustomerName = "홍길동"; }
    static void DiscountPrice(int price) { price = 0; }

    static void UpdateMajor(Student s) { s.Major = "소프트웨어공학"; }
    static void SkipGrade(int grade) { grade = 1; }

    static void SwitchMenu(OrderFood f) { f.Menu = "피자"; }
    static void ResetQuantity(int quantity) { quantity = 0; }

    static void Main(string[] args)
    {
        Computer simplePC = new Computer("Samsung");
        simplePC.TurnOn();
        simplePC.Reboot();
        simplePC.TurnOff();

        Computer myPC = new Computer("Apple", "MacBook", "개발용", "macOS", 16, 512, 13.3);
        myPC.TurnOn();
        myPC.RunProgram("VSCode");
        myPC.SaveFile("Program.cs");
        myPC.ConnectInternet();
        Console.WriteLine($"브랜드: {myPC.Brand}");
        ChangeBrand(myPC);
        Console.WriteLine($"변경 후 브랜드: {myPC.Brand}");
        int originalMemory = myPC.Memory;
        ScaleMemory(originalMemory);
        Console.WriteLine($"메모리 변경 시도 후: {originalMemory}\n");

        Order tempOrder = new Order(999, "임시주문자");
        tempOrder.CreateOrder();
        tempOrder.CancelOrder();

        Order order = new Order(1, "지민우", "2025-05-07", "기계식 키보드", 1, 85000, "대전시 오정동", "010-1234-5678");
        order.CreateOrder();
        order.Pay();
        order.Deliver();
        Console.WriteLine($"주문자: {order.CustomerName}");
        ChangeOwner(order);
        Console.WriteLine($"변경 후 주문자: {order.CustomerName}");
        int originalPrice = order.Price;
        DiscountPrice(originalPrice);
        Console.WriteLine($"가격 변경 시도 후: {originalPrice}\n");

        Student unknown = new Student("김철수", 20221111);
        unknown.CheckAttendance();

        Student me = new Student("지민우", 20222305, "컴퓨터공학", 3, 3.9, 92.0, "20222305@gm.hannam.ac.kr", "010-1234-5678");
        me.CheckAttendance();
        me.InputGrade(4.5);
        me.CheckGrade();
        Console.WriteLine($"전공: {me.Major}");
        UpdateMajor(me);
        Console.WriteLine($"변경 후 전공: {me.Major}");
        int originalGrade = me.Grade;
        SkipGrade(originalGrade);
        Console.WriteLine($"학년 변경 시도 후: {originalGrade}\n");

        OrderFood quickOrder = new OrderFood(200, "지민우");
        quickOrder.SelectMenu("피자");
        quickOrder.InputQuantity(2);

        OrderFood lunchOrder = new OrderFood(101, "지민우", "2025-05-07", "치킨", 1, 18000, "대전시 오정동", "010-1234-5678");
        lunchOrder.CreateOrder();
        lunchOrder.CalcPrice();
        lunchOrder.Pay();
        Console.WriteLine($"주문 메뉴: {lunchOrder.Menu}");
        SwitchMenu(lunchOrder);
        Console.WriteLine($"변경 후 메뉴: {lunchOrder.Menu}");
        int originalQty = lunchOrder.Quantity;
        ResetQuantity(originalQty);
        Console.WriteLine($"수량 변경 시도 후: {originalQty}\n");
    }
}