#!/bin/bash
# 날짜별 .NET 프로젝트 생성 스크립트 (macOS/Linux)
# 사용법: ./create-daily-project.sh 0318

if [ -z "$1" ]; then
    echo "사용법: $0 <날짜(MMDD)>"
    echo "예시:   $0 0318"
    exit 1
fi

DATE=$1
PROJECT_NAME="dotnet$DATE"
PROJECT_PATH="./$PROJECT_NAME"

if [ -d "$PROJECT_PATH" ]; then
    echo "오류: '$PROJECT_PATH' 폴더가 이미 존재합니다."
    exit 1
fi

echo "프로젝트 생성 중: $PROJECT_NAME"
dotnet new console -n "$PROJECT_NAME" -f net10.0

MONTH="${DATE:0:2}"
DAY="${DATE:2:2}"
YEAR=$(date +%Y)
FULL_DATE="${YEAR}년 ${MONTH}월 ${DAY}일"

cat > "$PROJECT_PATH/README.md" << 'TEMPLATE_EOF'
# .NET 학습 - PLACEHOLDER_DATE

## 📚 학습 주제
- 주제를 여기에 작성하세요

## 📝 학습 내용

### 1. 첫 번째 주제
- 설명을 작성하세요
- 코드 예시:
```csharp
// 여기에 코드 작성
```

### 2. 두 번째 주제
- 설명을 작성하세요

## 💡 주요 개념
- 개념 1
- 개념 2

## 🔍 실습 코드
- `Program.cs`: 메인 예제

## ✅ 체크리스트
- [ ] 기본 문법 이해
- [ ] 코드 실행 확인
- [ ] 응용 문제 풀이

## 🤔 궁금한 점 / 추가 학습 필요
-

## 📌 참고 자료
- [Microsoft .NET 문서](https://learn.microsoft.com/dotnet/)
TEMPLATE_EOF

sed -i '' "s/PLACEHOLDER_DATE/$FULL_DATE/" "$PROJECT_PATH/README.md"

cat > "$PROJECT_PATH/.gitignore" << 'EOF'
bin/
obj/
*.user
*.suo
.vs/
EOF

echo ""
echo "✅ 프로젝트 생성 완료!"
echo "📁 경로: $PROJECT_PATH"
echo "🚀 실행 방법: cd $PROJECT_NAME && dotnet run"
echo "📝 README.md 파일을 수정하여 학습 내용을 정리하세요"
