## 부산시 전시회 정보조회앱
- 데이터포털 OpenAPI 사용
- mssql 데이터베이스 연결

- 기능
    - 조회
        - 보여주고자 하는 정보만 출력
            - 전시번호, 제목, 전시시작일, 전시종료일, 장소

        ![조회](https://raw.githubusercontent.com/HyungJuu/My-Project/main/images/PJ2_002.png)
	
    - 전시회와 관련된 url 열기
        - 해당 전시회 더블클릭 &rarr; 관련 url을 불러온다

        ![url](https://raw.githubusercontent.com/HyungJuu/My-Project/main/images/PJ2_003.png)


	- 저장
		- 연결된 데이터베이스에 조회한 전시회 정보 저장
	
		![저장](https://raw.githubusercontent.com/HyungJuu/My-Project/main/images/PJ2_004.png)

- 조회한 전시회 정보를 데이터베이스에 저장함
- 메인창에서 년도를 검색하면 데이터베이스에서 해당 년도의 전시회를 불러오도록... 추가예정
