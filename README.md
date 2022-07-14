# Portfolio

 ## 학습활동
 - [C# 자기주도 학습 모둠](#자기주도-학습-모둠)
 - [주식 프로그램(php)](#주식-프로그램-php)
 - [전자회로 실험](#전자회로-실험)
 - [통신시스템 설계](#통신시스템-설계)
 - [데이터베이스 설계](#데이터베이스-설계)
 - [임베디드 시스템 설계](#임베디드-시스템-설계)
 
 ## 팀 프로젝트
 - [안드로이드 앱개발(하계방학)](#안드로이드-앱개발-하계방학)
 - [주식 프로그램(c#)](#주식-프로그램)
 - [자동문 프로젝트](#자동문-프로젝트)
 - 갖다드림 프로젝트
 - we-up 프로젝트
 - 스마트 이어폰
 - gdsc해커톤 대회
 
 ## 학업외 활동
 - 우리말가꿈이
 - 프로보노 공모전(노인 낙상 방지)

___

# 자기주도 학습 모둠
<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/177314885-148431ba-309a-4ff2-aef6-7f5c6b9bd82b.PNG">
<img width="500" alt="2" src="https://user-images.githubusercontent.com/79968300/177314896-7a9e3ac5-b912-4812-9dc2-b7edef8a60a2.PNG">
<img width="500" alt="3" src="https://user-images.githubusercontent.com/79968300/177314912-36d58dad-290f-4801-b534-6701f59dad7d.PNG">

객체지향에서 더 나아가 GUI로 프로그램을 구현하는 것이 처음이라 어려움을 느꼈다. 기존에 서로 지식을 공유하는 것이 좋은 공부방법이라는 것을 깨닫고 친구들과 함께 자기 주도학습 모둠에 참여했다. 그러나 C#은 모두 처음이기 때문에 지도 교수님을 통해 모임의 공부 방향을 설정하였다. 주 활동은 프로그램을 제작하며 그때마다 필요한 이론들을 공부했고 간단한 프로그램 하나를 완성하였다. 기초적이었지만 수업에서 배운 개념이 대부분 사용된 것을 보고 좋은 공부방법임을 깨닫고 높은 성적을 받을 수 있었다.



___

# 주식 프로그램 php

 서버 프로그래밍 자유주제 과제로 모의 주식 프로그램을 만들었다. C# 프로젝트를 할때는 데이터베이스를 사용하지 않아 심한 메모리 낭비가 있었는데 이번엔 데이터베이스를 사용하여 만들었다. 데이터베이스는 크게 company(주식회사), AI(주식을 사고파는 임의에 사람들), User_stock(사용자)로 구성되어 있다.
 
<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/177317758-da0647cc-e5be-4a2b-9aa8-4ff4e66766e3.PNG">

ai는 주식을 사고사는 사람들을 임의로 정해 둔 것으로 가지고 있는 돈에 따라 flex집단, rich집단, normal집단, poor집단으로 구성되어 있다. 각각의 이름 및 아이디는 임의로 정하였고, 번호가 1~5번인 사람은 10억(flex)에 해당하고, 6번에서 10번인 사람은 5억(rich)에 해당하고, 11번에서 26번인 사람은 1천만원(normal)에 해당하고, 27번에서 35번인 사람은 1백만원(poor)에 해당한다. 각각 아이디 및 가지고 있는 주식, 주식의 개수, 자산 등으로 테이블을 구성했다. flex_ai가 주식을 살 확률은 1%이다. poor_ai로 내려 갈때마다 주식을 살 확률이 늘어난다. ai가 가지고 있는 돈과 주가를 비교하여 주식을 사게 되는데 한 번 주식을 살 때마다 700개씩 산다. 이는 poor_ai로 갈수록 축소된다. 그렇기 때문에 flex_ai가 움직이게 되면 주가에 큰 변동이 있다. ai는 주식을 사는 행동을 확률로 사기 때문에 그 확률에 미치지 못했다고 해서 페이지가 만료 되면 안되기 때문에 페이지를 계속 새로고침 하면서 계속해서 작동을 한다. 사용자는 첫 로그인을 하면 100만원으로 주식을 사고 팔 수 있다.  
___

# 전자회로 실험

<img width="891" alt="1" src="https://user-images.githubusercontent.com/79968300/178684918-900b7f32-ecd6-4761-a91a-33f737835388.PNG">

2학년 1학기 전자회로를 수강했다. 직접 만든 회로를 직접 프로그래밍하여 하나의 완성품을 만들어다. 따라서 옴의 법칙부터 다이오드, 트랜지스터의 원리와 특성, 기자재 사용방법 등 실습의 기초가 되는 지식들을 공부했다. 소자와 기자재들을 이용해 이론들을 검증하는 과정에서 오히려 수업을 들을 때 이해가 되지 않던 개념들을 실습을 통해 이해하는 경우도 있었다. 실습결과를 보고서로 작성하면서 공학도들은 정확한 수치를 바탕으로 보고서를 작성하는 것이 중요하다고 느꼈다. 이 수업을 바탕으로 하드웨어에 대한 이해를 할 수 있었다.

___

# 통신시스템 설계

K=4 짜리 Convolutional Encoder와 Decoder를 Python으로 프로그래밍 하는 프로젝트를 구현하였다. K=3짜리인 경우와 K=4짜리인 경우에 QPSK의 BER이 0db~8db 까지 그려지도록 프로그래밍 했다.

<img width="500" alt="12" src="https://user-images.githubusercontent.com/79968300/178689226-451604fe-55bf-4a56-af7d-095142011c20.PNG">

다음 두 그림은 data_size = 1000000 이고, max_snr = 9 로 총 10번 돌아가는 k=4와 k=3 결과 화면이다. 왼쪽 그림이 k=4이고, 오른쪽 그림이 k=3 그래프다. 그림에서 볼수 있듯이 data_size 값과 max_snr값을 고정 시켰음에도 불구하고 k=4인 경우에는 y축이 10^-5 이상으로 그래프가 그려지고, k=3인 경우는 10^-5에 가깝거나 조금 멀게 그려진다. 그래프 자체도 k=4 그래프는 곡선형으로 완만하게 떨어지고 k=3 그래프는 k=4 그래프에 비해 찌그러진 곡선 모양이다. 이는 k=4 그래프가 더 성능이 좋다고 볼 수 있다. 이러한 결과가 나온 이유는 인코딩과 디코딩 과정을 거치는 비트의 수가 늘어났기 때문이다. 인터리버를 추가로 구현하지 못했지만 인터리버를 통해 비트를 재배열 하는 과정을 거친다면 ber 그래프가 좀 더 곡선형으로 보일 것이며 오류 검출 및 수정 과정도 더 원만하게 이루어졌을 것으로 예상 된다.  


___

# 데이터베이스 설계

데이터베이스 설계 프로젝트 주제는 야구로 설정했다. 타자, 투수 테이블을 조인하여 2020년에 롯데 상대로 강했던 타자, 롯데 상대로 강했던 투수 테이블을 METRICS 테이블로 생성한다. 그 테이블을 통하여 2020년 롯데 상대 전적을 만들고, 이렇게 파악한 데이터를 바탕으로 2021년에 롯데 상대로 팀 RANKING테이블을 생성하여 2021년에는 롯데 상대로 어떤 팀이 강하고 어떤 팀이 약한지 예측하는 테이블을 생성했다. 데이터를 가져오기 위해서 http://www.kbreport.com/main 를 이용하여 데이터를 엑셀파일로 수정하여 IMPORT 하였다. 

<img width="700" alt="1" src="https://user-images.githubusercontent.com/79968300/178698433-f995566c-052a-4194-859a-ede31401ea25.PNG">

다음 데이터베이스는 2020년 롯데 상대전적이다. 이 표를 참고하면 가장 신빙성이 있는 데이터를 크게 투수 부분과 타자 부분으로 나우어 추출한다. 투수 부분은 RA9_WAR(9이닝당 투수 WAR수치) 데이터와 ERA(평균 자책점) 데이터를 사용한다. 타자 부분은 WRC(조정 득점 창출력 즉 득점을 만들어낼 수 있는 능력)데이터와 WOBA(전체적인 공격 기여도)를 사용하여 데이터를 창출한다. 2020년 롯데 상대 전적 데이터를 분석해보면 NC와 KIA가 공동 1등인 것을 볼 수 있다. NC는 타자 데이터가 투수 데이터를 압살 할 정도로 높고, KIA는 타자 데이터와 투수 데이터 모두 준수하다고 볼 수 있다. 또, 상위권에 위치한 두산 역시 타자 데이터, 투수 데이터 모두 준수한 성적을 냈다. 삼성, SSG, 키움 팀은 4위에 위치한것을 볼 수 있는데 3팀 모두 BAKANCE형으로 투수와 타자 성적을 합쳐서 봤을 때 어떤 팀은 투수가 강하지만 타자가 약하고, 반대로 타자가 강하지만 투수가 강함으로써 상쇄되는 것을 볼 수 있다. 6팀이 롯데보다 강하거나 비슷했다. 롯데보다 약했던 3팀은 LG, KT, 한화로 LG는 투수가 평균 수준이지만 그에 반해 타자가 너무 약했다는 것을 확인할 수 있고, KT는 타자가 강했지만 투수가 평균 이하 수준으로 약했다는 것을 확인할 수 있다. 한화는 모든 수치가 최하수치이므로 9등인 것을 확인할 수 있다.

<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/178700189-f48ed076-3389-4333-8c7d-4b99db67672f.PNG">

다음 표는 가공된 데이터를 이용한 각 팀 수치이다. 각 데이터를 분석 하면 NC는 투수력이 하위권 수준이지만 타자 데이터가 상당히 높은 것을 확인할 수 있다. 하지만 작년과 비교하면 공격력은 비스하지만 투수력이 더 낮아졌다. 두산은 투수력과 공격력 모두 상위권인 것을 확인할 수 있다. KIA는 공격력 투수력 모두 준수한 것을 볼 수 있다. KT는 평균 자책점은 약하지만 나머지 부분이 상위권에 랭크 되어있다. 삼성은 투수력이 좋고 타자가 약하며 LG는 투수와 타자가 조화를 이루고 있다. SSG와 키움은 투수, 타자 모두 낮은 편인 것을 확인할 수 있다. 한화는 작년과 마찬가지로 모두 하위권이다. 

<img width="500" alt="2" src="https://user-images.githubusercontent.com/79968300/178700837-8cd8a825-6b96-4dc6-a06f-2da7bd268481.PNG">

따라서 2021년 롯데 자이언츠에 상대 RANKING 시스템은 다음과 같이 예측했다.

___

# 임베디드 시스템 설계

임베디드 시스템 설계에서는 자신만의 Shell 프로그램을 작성하는 프로젝트를 했다. 프로그램을 실행하면, 프롬포트가 나타나면서 명령어 입력을 대기하고, 명령어를 키보드로 입력하면 이를 실행하고 다시 명령어 입력을 대기한다. 


i. 구현한 명령어 목록
- cat, pwd, cd, mkdir, ls, history, ![number] - histroy, ps, cp, rm, ln, stat, chmod, alias, exit


ii. 구현한 명령어에 대한 설명 및 사용 예제

- cat : 1개 이상의 파일을 화면에 출력
- pwd : 현재 working 디렉토리 출력
- cd : working 디렉토리 변경
- mkdir : 디렉토리 생성
- ls : 현재 디렉토리에 있는 파일 이름을 출력
- history : 과거 사용된 명령어를 출력
- ![number] - histrory : 과거 사용된 명령어를 재실행 (Ex. !123)
- ps : 실행중인 process를 출력
- cp : 파일 복사
- rm : 파일 및 디렉토리 삭제
- ln : harn link 작성
- stat : 파일의 status를 출력
- chmod : 파일의 permission을 변경
- alias : 명령어를 alias
- exit : shell 종료
 
iii. 주요 코드에 대한 코드 분석

## 1) cat
```c
int cat(char argv[100]){
	FILE *fp;
	char buf[255];
	char *filename = NULL;
	filename = strtok(argv," ");
	while(filename != NULL){
		fp = fopen(filename,"r");
		if(fp==NULL){
			printf("cat: %s: No such file or directory\n",filename);
			return -1;
			}

		filename = strtok(NULL, " ");
		while(fgets(buf,255,fp) != NULL){
			printf("%s",buf);
		}
	}
	return 0;

	fclose(fp);

}
```

 Minishell에서 사용자가 입력한 값이 cat이면 cat 함수를 호출한다. cat 함수를 호출 하기전에 main문에서 %[^\n]s 형태로 문자열을 받는다. 이는 공백을 포함하여 문자열을 넘겨 주겠다는 뜻이며 사용자가 다수의 파일을 입력할 때도 오류없이 정상 동작한다. cat함수를 살펴보면 우선 사용자가 넘긴 값을 strtok를 통해 공백을 기준으로 문자열을 자른다. 그 자른 문자열을 하나씩 fopen 함수를 통하여 파일을 오픈한다. 만약 파일값을 입력하지 않았다면 –1을 반환하고, 정상적으로 입력했다면 0을 반환한다. 이는 main 문에서 cat_num 값이 –1이라면 continue를 수행하여 잘 못 입력했다는 것을 알 수 있다. 
 

## 2) pwd

```c
char* getcwd(char* buf,size_t size);
void pwd(void){
	char buf[100];
	getcwd(buf,100);
	printf("%s \n",buf);
}
```

 Minishell에서 사용자가 입력한 값이 pwd이면 pwd 함수를 호출한다. pwd 함수는 getcwd 함수를 이용하여 만들었다. 여기서 getcwd는 작업 중인 디렉토리 이름을 가져오는 기능이고, (char *buf, size_t size) 중 buf는 작업중인 디렉토리의 이름을 담을 버퍼이다. size_t size는 버퍼의 크기이다. 이 함수의 return 값은 현재 작업중인 디렉토리를 반환하므로 pwd 함수에서 getcwd 함수를 호출하여 완성된다.







## 3) cd 
```c
void cd(char argv[]){
	char buf[30];
	if(chdir(argv)==0){
			getcwd(buf,30);
			printf("path : %s\n", buf);
	}
	else{
		printf("path error\n");
	}
}
```

 Minishell에서 사용자가 입력한 값이 cd이면 cd함수를 호출한다. chdir(경로)를 사용한 결과 0이 나오면 경로 이동이 성공한다. 만약 0이 아니라면 변경에 실패한다.

## 4) mkdir
```c
void mk(){
	char path[1024];
	int end = 0;
	int result = 0;
	write(1,"input : ",7);
	read(0,path,1024);
	while(path[end]!='\n'){
		end++;
	}
	path[end] = 0;
	result = mkdir(path,0755);
	if(result < 0){
		write(1,"failed\n",7);
	}
	else{
		write(1,"success\n",8);
	}
}
```

 Minishell에서 사용자가 입력한 값이 mkdir 이면 mk 함수를 호출한다. 여기서 read는 경로 입력이고, write는 디렉터리 생성 성공과 실패를 출력한다. mkdir는 디렉터리를 생성 하고 성공시 0을 반환한다. 먼저 read 함수로 경로를 입력받는다. read 함수는 입력받은 문자열에 자동으로 개행 문자가 들어가게 된다. 경로에는 개행 문자(\n)가 들어갈 수 없기 때문에 제거한다. while문을 이용해서 개행 문자를 찾으면 0으로 값을 변경하도록 한다. mkdir에 기본 함수 형은 mkdir(경로 이름, 권한) 이다. 디렉터리의 기본 권한은 755 이므로 result에 경로와 0755를 넣는다. 마지막 부분에는 디렉터리를 생성해서 반환 값에 따라 메시지를 출력한다.


## 5) ls
```c
 void ls(){
	char *cwd = (char*)malloc(sizeof(char)*1024);
	DIR* dir = NULL;
	struct dirent* entry = NULL;
	getcwd(cwd,1024);
	if((dir=opendir(cwd))==NULL){
		printf("current directory error\n");
	}
	while((entry = readdir(dir))!=NULL){
		if(entry->d_name[0]=='.'){
				continue;
				}
		printf("%s\n",entry->d_name);
	}
	free(cwd);
	closedir(dir);
}   
```
 
 Minishell에서 사용자가 ls를 입력하였을 때 ls 함수를 호출한다. ls는 기본적으로 opendir함수와 readdir 함수를 사용한다. opendir 함수는 매개변수에 해당하는 디렉토리 스트림을 열고 그 디렉토리 스트림에 대한 포인터를 반환한다. readdir 함수는 dirent 구조체 내에 있는 디렉토리 내용을 읽는다. 먼저 동적 메모리 할당을 하고, dirent 구조체에 접근한다. dirent 구조체는 파일, 또는 디렉토리가 가지고 있는 정보 구조체이다. 여기서 파일을 read할 때 파일명 앞에 .이 붙어있다면 히든 파일이다. 그 히든 파일을 숨기기 위해 entry->d_name[0] 값이 . 이라면 continue 시켜 출력 시키지 않는다.

   
## 6) history
```c
	scanf("%s",buffer);
		words[n] = strdups(buffer);
		n++;
		if(strcmp(buffer,"history")==0){
			for(int i = 0 ; i<n; i++)
				printf("[%d] %s\n",i+1,words[i]);
			scanf("%s",his);
```
 
 history는 따로 함수를 만들지 않고, main문에서 사용자가 명령어 또는 값을 입력할 때마다 strdups함수를 사용하여 words 포인터 배열 변수에 저장한다. 만약 사용자가 history를 입력하면 words 배열에 있는 값들을 모두 출력한다. 

## 7) ![number] history
```c
scanf("%s",his);
			if(his[0] == '!'){
				char *p = strtok(his, "!");
				num = atoi(p);
				printf("%s\n",words[num-1]);
				strcpy(buffer,words[num-1]);
			if(strcmp(buffer,"cat")==0){
				char s1[100];
				getchar();
				scanf("%[^\n]s",s1);
				cat_num = cat(s1);
				if(cat_num==-1){
					continue;
				}
				}
``` 
사용자가 history를 입력한다면 scnaf 함수를 다시 사용하여 !숫자 값을 받기를 기다린다. his라는 배열을 이용하여 만약 his[0]이 !라면 ![number] 기능을 사용한다는 뜻이기 때문에 함수가 동작한다. 먼저 포인터 문자 변수에 strtok를 사용하여 !를 제외한 값을 저장한다. 그리고 그 값을 atoi함수를 통해 문자열을 정수로 바꾼다. words[n]은 0부터 시작하기 때문에 words[n-1]이 사용자가 원하는 값이 된다. 그 값을 출력하고, strcpy를 통해 buffer에 문자열 복사를 한다. buffer에 복사된 값을 명령어들과 하나씩 비교하여 만약 그 명령어가 있다면 수행한다.  

## 8) ps
```c
void ps(){
	DIR *dir;
	struct dirent *entry;
	struct stat fileStat;
	int pid = getpid();
	int pid2 = getppid();
	int uid = getuid();
	int pid3;
	char cmdLine[256];
	char tempPath[256];
	printf("PID   CMD\n");
	dir = opendir("/proc");
	while((entry=readdir(dir))!=NULL){
		pid3 = atoi(entry->d_name);
		if(pid3<=0) continue;
		sprintf(tempPath,"/proc/%d/cmdline",pid3);
		getCmdLine(tempPath, cmdLine);
		if(pid==pid3)
			printf("%d  %s\n",pid,cmdLine);
		if(pid2==pid3)
			printf("%d  %s\n",pid2,cmdLine);
}
}
int getCmdLine(char *file, char *buf){
	FILE *srcFp;
	int i;
	srcFp = fopen(file,"r");
	memset(buf,0,sizeof(buf));
	fgets(buf,256,srcFp);
	fclose(srcFp);
}
```
  pid값을 얻기 위해서는 getpid()와 getppid() 함수를 사용한다. 디렉토리 이름이 proc/pid/cmdiline 이라면 프로세스 이름을 알 수 있다. 이 때 부모 프로세스에 pid 값과 자식 프로세스에 pid 값을 이용한다. while문을 통하여 /proc에 존재하는 파일들을 차례대로 읽는다. 그리고 pid3 변수에 숫자로 반환한다. /proc/pid/cmdline에서 프로세스의 이름을 가져오는 함수로 보낸다. getCmdLine에서는 tempPath값과 cmdline값을 받아서 모든 값을 반환한다. 여기서 부모 프로세스 pid 값과 자식 프로세스 pid 값을 이용하여 출력한다.
 
## 9) cp
```c
void cp(char *arg[100],char *argv[100]){
	char ch;
	int src, dst;
	src = open(arg,O_RDONLY);
	dst = open(argv,O_WRONLY | O_CREAT | O_TRUNC, 0644);
	while(read(src,&ch,1))
		write(dst,&ch,1);
	close(src);
	close(dst);
}
 ```
 cp는 명령어를 동작할 때 scnaf(“%s%s”)로 2개의 값을 받는다. 변수 src에 복사 할 파일을 RDONLY를 사용해 읽기 전용으로 open한다. 변수 dst에는 새로 생성될 파일에 O_WRONLY | O_CREAT | O_TRUNC, 0644 를 사용해 소유자는 읽기/쓰기가 가능하며, 나머지 모든 사람은 읽기만 가능하게 한다.

## 10) rm
```c
void rm(){
	char name[30];
	scanf("%s",&name);

	int nResult = remove(name);
	if(nResult == -1){
		printf("fail\n");
	}
}
```
 사용자가 rm을 입력하면 rm 함수가 동작한다. scanf를 통해 삭제시킬 명령어를 받는다. remove 함수를 사용하여 파일을 삭제한다. unlink는 비어있는 디렉토리는 에러가 나지만 remove 함수는 비어있는 디렉토리도 삭제가 가능하다. 만약 nResult 값이 –1을 반환한다면 삭제에 실패한 것이다. 

## 11) ln
```c
void ln(){	
	char a[30];
	char b[30];
	scanf("%s %s",a,b);
	link(a,b);
}
```
 사용자에게 link로 연결할 값을 scanf를 통해 2개로 받는다. 그 값을 link를 통해 하드링크로 생성한다.

## 12) stat
```c
void st(){
	char *c[30];
	scanf("%s",c);
	struct stat sb;
	
	if(lstat(c,&sb) == -1){
		perror("lstat");
	}
	if(lstat(c,&sb) == 0){
		printf("ID of containing device : [%lx, %lx]\n",(long) major(sb.st_dev), (long) minor(sb.st_dev));
		printf("File type:                  ");
		switch (sb.st_mode & S_IFMT){
			case S_IFBLK: printf("block device\n");  break;
			case S_IFCHR: printf("character device\n");  break;
			case S_IFDIR: printf("directory\n");  break;
			case S_IFIFO: printf("FIFO/pipe\n");  break;
			case S_IFLNK: printf("symlink\n");  break;
			case S_IFREG: printf("regular file\n");  break;
			case S_IFSOCK: printf("socket\n");  break;
			default : printf("unknown?\n"); break;
		}
		printf("I-node number:                %ld\n", (long)sb.st_ino);
		printf("Mode:                %lo (octal)\n", (unsigned long)sb.st_mode);
		printf("Link count:                %ld\n", (long)sb.st_nlink);
		printf("Ownership:           UID=%ld   GID=%ld\n", (long)sb.st_uid, (long)sb.st_gid);
		printf("Preferred I/O block size: %ld bytes\n", (long)sb.st_blksize);
		printf("File size:                %lld bytes\n", (long long)sb.st_size);
		printf("Blocks allocated:                %lld\n", (long long)sb.st_blocks);
		printf("Last status change:                %s\n", ctime(&sb.st_ctime));
		printf("Last file access:                %s\n", ctime(&sb.st_atime));
		printf("Last file modification:                %s\n", ctime(&sb.st_mtime));
	}
}
 ```
 파일의 크기, 파일의 권한, 파일의 생성일시, 파일의 최종 변경일 등, 파일의 상태나 파일의 정보를 얻는 함수이다. 
stat 구조체
dev_t st_dev; ID of device containing file 
ino_t st_ino; inode number 
mode_t st_mode; 파일의 종류 및 접근권한 
nlink_t st_nlink; hardlink 된 횟수 
 uid_t st_uid; 파일의 owner 
gid_t st_gid; group ID of owner  
dev_t st_rdev; device ID (if special file) 
off_t st_size; 파일의 크기(bytes) 
blksize_t st_blksize; blocksize for file system I/O
blkcnt_t st_blocks; number of 512B blocks allocated 
time_t st_atime; time of last access 
time_t st_mtime; time of last modification
time_t st_ctime; time of last status change
이 중에서 주요 내용은 st_mode : 파일의 종류와 파일에 대한 access 권한 정보 파일의 종류를 체크한다. 

## 13) chmod
```c
int mode = 0;
scanf("%o",&mode);
char a[30];
scanf("%s",a);	
if(access(a,F_OK)!=0){
	printf("%s is not existed\n",a);
	}	
if(chmod(a,mode)!=0){
	printf("fail\n");
	}	
else{
	printf("success\n");
				
}
```
 mode로 입력받는 8진수는 맨 앞 자리는 사용자, 두 번째는 그룹, 세 번째는 나머지를 의미하며 4는 읽기, 2는 쓰기 1은 실행 권한을 의미한다. 리눅스에서 access 함수를 사용하여 함수로 파일에 읽기, 쓰기, 실행 권한이 존재하는지 확인할 수 있다. F_OK는 파일 존재 여부 확인으로 실패 시 –1을 리턴 하고, 성공 시 0을 리턴 한다. chmod 함수에 접근하여 만약 반환값이 0이 아니라면 실패한다. 

 





## 14) alias
```c
else if(strcmp(buffer,"alias")==0){
			scanf("%s",ali);
			sscanf(ali,"%[^=]=%s",name[k].fake_name,a);
			char *ac = strtok(a,"\'");
			while(ac!=NULL){
				strcpy(name[k].real_name,ac);
				ac=strtok(NULL,"\'");
			}
			k++;
			}

		for(int i=0; i<k;i++){		

		if(strcmp(buffer,name[i].fake_name)==0 &&strcmp(name[i].real_name,"cat")==0){
			char s1[100];
			getchar();
			scanf("%[^\n]s",s1);
			cat(s1);
			}   
```
 먼저 구조체 배열을 선언한다. 구조체 배열에는 fake_name[100] (별명) real_name[100] (명령어) 로 구성한다. 만약 사용자가 alias를 입력한다면 scanf를 통해 a=’ls’ 값을 받는다. 여기서 먼저 sscnaf를 통해 =을 기준으로 앞에 있는 값을 fake_name[k]에 저장한다. 여기서 k값은 무한 반복문이 수행되기 전에 0으로 초기화 되어 있고, alias가 수행된다면 k++로 값을 늘려준다. =으로 자르고 남은 ‘ls’ 값을 strtok을 통하여 작은 따옴표를 분리하여 real_name[k]에 저장한다. 반복문을 통해 사용자가 명령어를 입력할 때 만약 별명 배열에 저장되어 있는 값과 똑같고 실제 명령어 배열에 Minishell에 구현되어 있는 명령어 중 하나가 있다면 동작하게 된다. 

## 15) exit

   만약 사용자가 exit를 입력하면 break를 통해 무한 반복문을 끝낸다.

___

# 안드로이드 앱개발 하계방학

<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/178711136-3dfadcfa-6020-40f0-89df-3b81fb05df9c.PNG">

1학년 여름방학 안드로이드 앱 개발 프로그램을 수강했다. 당시 메인 개발자를 담당했다. 처음에는 클래스를 처음 접했기 때문에 어려움을 느꼈지만 잘 만들어 냈다. 간단한 회원가입과 로그인 기능을 구현했으며, 인스타그램 형식으로 게시물 및 좋아요 댓글을 달 수 있는 프로젝트를 제작하였다. 이를 구현해 수상하였고, 2학기에 있던 객체지향 프로그래밍에서도 좋은 성적을 거두었다. 처음으로 한 팀 프로젝트로 팀원과의 협업과 의사소통을 잘 이끌어 내 좋은 결과를 받을 수 있었다.
___

# 주식 프로그램

<img width="825" alt="1" src="https://user-images.githubusercontent.com/79968300/178911910-da0a311c-d1ca-42f6-a252-ded6c63f3872.PNG">

GUI 프로그래밍을 수강하여 팀 프로젝트를 진행하였다. 주식 프로그램을 만들게 되었는데 실제로 데이터베이스를 쓰지 않고, 구현하여 사용했다. 지금까지 배웠던 파일 입출력과 딕셔너리를 이용하였고, 데이터를 저장하고 불러오는 기능을 만들 수 있었다. 1 초당 3일을 기준으로 잡고 사용자를 제외한 주식을 사고파는 사람들은 특성에 따라 나눴다. 주식을 한번에 많이 사고 파는 사람, 주식을 적게 사고 파는 사람들로 분류하여 자동으로 사고 파는 시스템이다. 전반적으로 자동으로 사고파는 기능에 대해 역할을 맡아 구현하였다. 하지만 이 프로그램에 최대 단점은 파일 입출력을 통해 직접 데이터 베이스를 구현했기 때문에 메모리 낭비가 심하다는 점이다.

___

# 자동문 프로젝트

<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/178917509-c6efbea2-940c-404d-8706-4f17bcfff278.PNG">


시연영상 : https://youtu.be/wAZ9ZU-Ron8

ATmega128와 초음파센서를 이용해 자동문 프로젝트를 실시했다. 선정한 주제가 블루투스 모듈과 초음파센서를 이용한 자동문임에 따라 안드로이드 스튜디오를 이용하여 안드로이드 앱 개발도 하였다. 자동문이지만 앱을 구현한 이유는 초음파센서의 고장과 응급상황 발생 등에 여러 가지 돌발 상황을 대비하여 구성 했다. 앱을 동작시키면 자동모드와 관리자 모드로 나누어져 있는데 관리자 모드는 어플 안에 있는 열기와 닫기 버튼을 이용하여 문을 수동으로 여닫을 수 있다. 자동모드는 초음파 센서를 이용하여 일정한 거리안에 물체가 인식되면 문이 열리고 일정 시간 이후 문이 닫히는 구조로 구성된 모드이다. 그리고 어플을 동작시키면 연결하기와 연결해제 버튼이 있는데 연결하기 버튼을 누르면 ATmega의 블루투스 모듈과 연결할 수 있다. 자동문을 구현하기 위해 ATmega128에 초음파 센서 모듈을 연결하였고 초음파 센서의 인식된 값을 통해 문이 열리고 닫힘을 수행하기 위해 자동문 모서리 위에 서보모터를 장착했다. 
초음파 모듈을 이용하여 특정거리인 50을 기준으로 물체를 인식하게 했다. 정해놓은 특정거리에 벗어나 있으면 문이 열리지 않는다.  반대로 특정거리 내에 들어오게 되면 문이 열리게 된다.


___

# 갖다드림 프로젝트

시연영상 : https://youtu.be/t5VzGI4r0uI



___
