# .NET Program 학습 레포지토리

이 Repository는 `.NET Program` 과목을 수강하며 배운 내용들과 **C# 프로그래밍**을 공부하며 기록하는 개인 학습 레포지토리입니다.

날짜별로 학습한 내용을 정리하여 체계적으로 관리하고, 복습 및 포트폴리오로 활용하기 위해 만들어졌습니다.

## 📁 프로젝트 구조

```
dotnetProgram/
├── README.md                    # 이 파일
├── create-daily-project.sh      # 날짜별 프로젝트 자동 생성 스크립트 (macOS/Linux)
├── create-daily-project.ps1     # 날짜별 프로젝트 자동 생성 스크립트 (Windows PowerShell)
├── dotnet0311.slnx              # Visual Studio 솔루션 파일
│
├── dotnet0311/                  # 2026-03-11: 기본 자료형, 연산자, 자료형 변환
├── dotnet0318/                  # 2026-03-18: Hello World (프로젝트 초기화)
├── dotnet0325/                  # 2026-03-25: 조건문 (if/else, switch, 삼항 연산자)
├── dotnet0401/                  # 2026-04-01: 반복문, 배열, break/continue
├── dotnet0408/                  # 2026-04-08: 클래스 기초 (속성, 메서드, List, Math)
├── dotnet0429/                  # 2026-04-29: 클래스 심화 (생성자, Property, 오버로딩)
├── dotnet0506/                  # 2026-05-06: 상속, 오버라이딩, 추상 클래스, is/as
│
└── baekjoon/                    # 백준 알고리즘 문제 풀이
```

## 🚀 학습 워크플로우

### 1️⃣ 새로운 학습 날짜 프로젝트 생성

**macOS / Linux (추천)**

```bash
# 실행 권한 부여 (최초 1회만)
chmod +x ./create-daily-project.sh

# 프로젝트 생성
./create-daily-project.sh 0513
```

**Windows (PowerShell)**

```powershell
.\create-daily-project.ps1 -date "0513"
```

**수동 생성**

```bash
dotnet new console -n dotnet0513 -f net10.0
```

스크립트 실행 시 자동으로 생성되는 것:
- .NET 10 콘솔 프로젝트
- `README.md` 템플릿 (학습 내용 정리용)
- `.gitignore` (bin, obj 폴더 제외)

### 2️⃣ 코드 작성 및 실행

```bash
# 해당 날짜 폴더에서 실행
cd dotnet0513
dotnet run

# 루트 디렉토리에서 특정 프로젝트 실행
dotnet run --project dotnet0513
```

### 3️⃣ 학습 내용 정리

각 날짜별 `README.md`에 포함할 내용:
- 학습 주제 및 상세 내용
- 주요 개념 정리
- 실습 코드 목록
- 궁금한 점 / 추가 학습 필요 사항

### 4️⃣ Git 커밋 및 푸시

```bash
git add .
git commit -m "5월 13일 학습 내용"
git push origin main
```

## 🛠️ 기술 스택

- **.NET 10** / **C#**
- **Visual Studio Community 2022**

## 📚 참고 자료

- [Microsoft .NET 공식 문서](https://learn.microsoft.com/dotnet/)
- [C# 프로그래밍 가이드](https://learn.microsoft.com/dotnet/csharp/)
- [.NET API 브라우저](https://learn.microsoft.com/dotnet/api/)

## 📊 학습 진행 상황

| 날짜 | 주제 | 상태 |
|------|------|------|
| 2026-03-11 | 기본 자료형(int, double, char, string, bool), 산술·비교·논리 연산자, 형변환, Console 입출력 | ✅ |
| 2026-03-18 | Hello World, 프로젝트 초기화 | ✅ |
| 2026-03-25 | 조건문 — if/else if/else, 중첩 조건문, switch, 삼항 연산자 | ✅ |
| 2026-04-01 | 반복문 — while, do-while, for, foreach, 배열, break/continue | ✅ |
| 2026-04-08 | 클래스 기초 — 인스턴스 생성, 필드·메서드 정의, Random, List, Math | ✅ |
| 2026-04-29 | 클래스 심화 — 생성자/소멸자, Property, 메서드 오버로딩, static 변수, 캡슐화 | ✅ |
| 2026-05-06 | 상속, 섀도잉/하이딩(new), 오버라이딩(virtual/override), 추상 클래스, is/as 연산자 | ✅ |

---

**Happy Coding!**
