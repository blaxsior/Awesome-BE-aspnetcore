# 커맨드 명령어
## 빌드
- dotnet build: 빌드
## 생성
- dotnet new web: 최소 API 프로젝트 생성
- dotnet new webapi --use-controllers: 컨트롤러 기반 API 프로젝트 생성
- dotnet new webapi: MVC 프로젝트 생성
## 실행
- dotnet watch run: 감시 모드(변경사항 즉시 반영)로 프로젝트 시작
## 비밀 정보
[링크](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-8.0&tabs=windows#enable-secret-storage)

- dotnet user-secrets init: 유저 비밀 정보 활성화
- dotnet user-secrets set "key" "value": key-value 값으로 비밀번호 설정
## efcore
- dotnet ef migrations add &lt;name&gt;: 현재 코드 정의로 마이그레이션 생성
- dotnet ef database update: 최신 마이그레이션으로 db 업데이트