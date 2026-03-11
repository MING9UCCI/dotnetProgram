# dotnetProgram

Visual Studio 환경에서 진행하는 C# .NET 실습 프로젝트 저장소입니다.

---

## 브랜치 안내

| 브랜치 | 설명 |
|--------|------|
| `main` | **기본 브랜치** (모든 실습 코드는 이 브랜치에 정리) |
| ~~`master`~~ | 중복 브랜치 — 삭제 예정 |

> **참고:** `main`과 `master`는 꼬인 것이 아닙니다.  
> 두 브랜치가 동일한 커밋을 가리키고 있어 내용은 동일하며, 단순히 중복된 브랜치가 존재하는 상태입니다.  
> `main`이 기본 브랜치이므로 `master`를 삭제하면 정리됩니다.
>
> **`master` 브랜치 삭제 방법 (GitHub 웹에서):**  
> GitHub → 이 저장소 → Code 탭 → 브랜치 목록 → `master` 옆 🗑 아이콘 클릭

---

## 프로젝트 구조

```
dotnetProgram/
├── README.md
├── dotnet0311/          # 3월 11일 실습 — 기본 자료형, 연산자, 형 변환
│   ├── Program.cs
│   └── dotnet0311.csproj
├── dotnet0311.slnx      # 솔루션 파일
└── (이후 실습 폴더 추가 예정)
```

### 네이밍 규칙

새 실습 프로젝트를 추가할 때는 아래 규칙을 따릅니다:

```
dotnetMMDD/          # 월(MM) + 일(DD) 기준 폴더명
├── Program.cs
└── dotnetMMDD.csproj
```

예시:
- `dotnet0311/` → 3월 11일 실습
- `dotnet0318/` → 3월 18일 실습

---

## 실습 내용 목록

| 폴더 | 날짜 | 내용 |
|------|------|------|
| `dotnet0311` | 2025-03-11 | 기본 자료형(int, double, char, string, bool), 연산자, 증감 연산자, 형 변환 |

---

## 개발 환경

- **IDE:** Visual Studio 2022
- **Framework:** .NET 10
- **언어:** C#
