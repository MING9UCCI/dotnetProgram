# 날짜별 .NET 프로젝트 생성 스크립트
# 사용법: .\create-daily-project.ps1 -date "0318"

param(
    [Parameter(Mandatory=$true)]
    [string]$date
)

$projectName = "dotnet$date"
$projectPath = ".\$projectName"

# 프로젝트 생성
Write-Host "프로젝트 생성: $projectName" -ForegroundColor Green
dotnet new console -n $projectName -f net10.0

# README.md 생성
$year = Get-Date -Format "yyyy"
$month = $date.Substring(0, 2)
$day = $date.Substring(2, 2)
$fullDate = "$year년 ${month}월 ${day}일"

$readmeContent = @"
# .NET 학습 - $fullDate

## 📚 학습 주제
- 주제를 여기에 작성하세요

## 📝 학습 내용

### 1. 첫 번째 주제
- 설명을 작성하세요
- 코드 예시:
``````csharp
// 여기에 코드 작성
``````

### 2. 두 번째 주제
- 설명을 작성하세요

## 💡 주요 개념
- 개념 1
- 개념 2

## 🔍 실습 코드
- ``Program.cs``: 메인 예제

## ✅ 체크리스트
- [ ] 기본 문법 이해
- [ ] 코드 실행 확인
- [ ] 응용 문제 풀이

## 🤔 궁금한 점 / 추가 학습 필요
- 

## 📌 참고 자료
- [Microsoft .NET 문서](https://learn.microsoft.com/dotnet/)
"@

Set-Content -Path "$projectPath\README.md" -Value $readmeContent

# .gitignore 생성 (bin, obj 폴더 제외)
$gitignoreContent = @"
bin/
obj/
*.user
*.suo
.vs/
"@

Set-Content -Path "$projectPath\.gitignore" -Value $gitignoreContent

Write-Host "`n✅ 프로젝트 생성 완료!" -ForegroundColor Green
Write-Host "📁 경로: $projectPath" -ForegroundColor Cyan
Write-Host "🚀 실행 방법: cd $projectName; dotnet run" -ForegroundColor Yellow
Write-Host "📝 README.md 파일을 수정하여 학습 내용을 정리하세요" -ForegroundColor Magenta
