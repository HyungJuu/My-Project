# My-Project
개인 프로젝트

## [Project01](https://github.com/HyungJuu/My-Project/blob/main/Project01.md)
- C# 개인 프로젝트 : 개인 다이어리(메모장)
	- mssql 데이터베이스 연결

## [Project02](https://github.com/HyungJuu/My-Project/blob/main/Project02.md)
- WPF 개인 프로젝트 : 부산 전시회 조회앱
	- OpenAPI 연결
	- mssql 데이터베이스 연결

## mssql 연결
-> mssql에서 가져가고자 하는 데이터베이스 우클릭 -> 태스크 -> 스크립트 생성 -> 다음 -> 다음  
-> 스크립즈 저장방법에서 **스크립트 파일로 저장**  
-> 고급 -> DROP 및 CREATE 스크립팅 : DROP 및 CREATE 스크립팅, 스크립팅할 데이터 형식 : 스키마 및 데이터  
-> 그대로 쭉 진행  
-> 생성된 파일을 내려받고자 하는 컴퓨터에서 열기
```
CREATE DATABASE [DB명] // 아래부터
// 이부분 제거
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
```
-> F5누르면 모두 내려받기 가능
