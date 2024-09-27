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
[링크](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets)

- dotnet user-secrets init: 유저 비밀 정보 활성화
- dotnet user-secrets set "key" "value": key-value 값으로 비밀번호 설정
- dotnet user-secrets list: 현재 프로젝트의 유저 비밀 정보 보기
- dotnet user-secrets remove "key": key 데이터 제거
- dotnet user-secrets clear: 유저 비밀 정보 초기화
## efcore
- dotnet ef migrations add &lt;name&gt;: 현재 코드 정의로 마이그레이션 생성
- dotnet ef database update: 최신 마이그레이션으로 db 업데이트


# 의존성
- System.IdentityModel.Tokens.Jwt: JWT 관련 기능을 포함하고 있음

# 서비스 수명
- Singleton: 프로젝트 생명 주기에서 단 하나만 생성하고 모든 요청에서 재사용
- Scoped: 인스턴스를 하나의 요청에 대해 만들고 재사용
- Transcient: 인스턴스가 하나의 요청 내에서도 매번 새롭게 생성

ef core은 내부적으로 DbContext을 이용하여 데이터베이스의 상태를 관리한다. DbContext는 DB 데이터를 읽고 쓰는 하나의 단위를 의미하므로, 각 요청마다 생성되어야 한다. 이를 사용하는 Repository도 Scoped로 지정되어야 하므로 Asp.Net core에서는 spring과 달리 repository의 수명주기가 싱글톤이 아니다.

# 참고 링크
- ASPNET CORE FILTER: https://learn.microsoft.com/ko-kr/aspnet/core/mvc/controllers/filters

# 