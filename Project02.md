## 부산시 전시회 정보조회앱
- 데이터포털 OpenAPI 사용
- mssql 데이터베이스 연결

- 기능
    - 조회
        - 보여주고자 하는 정보만 출력
            - 전시번호, 제목, 전시시작일, 전시종료일, 장소
            - 조회수를 변경하고 싶을 때 : OpenApiUri의 numOfRows 숫자 변경  
                &rarr; 현재 : numOfRows=5000

        ![조회](https://raw.githubusercontent.com/HyungJuu/My-Project/main/images/PJ2_002.png)
	
    - 전시회와 관련된 url 열기
        - 해당 전시회 더블클릭 &rarr; 관련 url을 불러온다

        ![url](https://raw.githubusercontent.com/HyungJuu/My-Project/main/images/PJ2_003.png)


	- 저장
		- 연결된 데이터베이스에 조회한 전시회 정보 저장
	
		![저장](https://raw.githubusercontent.com/HyungJuu/My-Project/main/images/PJ2_004.png)

https://github.com/HyungJuu/My-Project/assets/158007420/864b44f0-7805-4e91-82f7-576828c725cd


- 조회한 전시회 정보를 데이터베이스에 저장함
- 메인창에서 년도를 검색하면 데이터베이스에서 해당 년도의 전시회를 불러오도록... 추가예정 &rarr; 구현완료
- 년도검색한 상태에서 더블클릭으로 url을 열수는 없을까.. &rarr; 확인필요





