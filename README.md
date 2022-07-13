# Portfolio

 ## 학습활동
 - [C# 자기주도 학습 모둠](#1-c#자기주도-학습-모둠)
 - [주식 프로그램(php)](#2-주식-프로그램(php))
 - [전자회로 실험](#3-전자회로-실험)
 - [통신시스템 설계](#4-통신시스템-설계)
 - [데이터베이스 설계](#5-데이터베이스-설계)
 - [임베디드 시스템 설계](#6-임베디드-시스템-설계)
 
 ## 팀 프로젝트
 - 안드로이드 앱개발(하계방학)
 - 주식 프로그램(C#)
 - 자동문 프로젝트
 - 갖다드림 프로젝트
 - 스마트 이어폰
 - gdsc해커톤 대회
 
 ## 학업외 활동
 - 우리말가꿈이
 - 프로보노 공모전(노인 낙상 방지)

___

# 1.c# 자기주도 학습 모둠
<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/177314885-148431ba-309a-4ff2-aef6-7f5c6b9bd82b.PNG">
<img width="500" alt="2" src="https://user-images.githubusercontent.com/79968300/177314896-7a9e3ac5-b912-4812-9dc2-b7edef8a60a2.PNG">
<img width="500" alt="3" src="https://user-images.githubusercontent.com/79968300/177314912-36d58dad-290f-4801-b534-6701f59dad7d.PNG">

객체지향에서 더 나아가 GUI로 프로그램을 구현하는 것이 처음이라 어려움을 느꼈다. 기존에 서로 지식을 공유하는 것이 좋은 공부방법이라는 것을 깨닫고 친구들과 함께 자기 주도학습 모둠에 참여했다. 그러나 C#은 모두 처음이기 때문에 지도 교수님을 통해 모임의 공부 방향을 설정하였다. 주 활동은 프로그램을 제작하며 그때마다 필요한 이론들을 공부했고 간단한 프로그램 하나를 완성하였다. 기초적이었지만 수업에서 배운 개념이 대부분 사용된 것을 보고 좋은 공부방법임을 깨닫고 높은 성적을 받을 수 있었다.



___

# 2.주식 프로그램(php)

 서버 프로그래밍 자유주제 과제로 모의 주식 프로그램을 만들었다. C# 프로젝트를 할때는 데이터베이스를 사용하지 않아 심한 메모리 낭비가 있었는데 이번엔 데이터베이스를 사용하여 만들었다. 데이터베이스는 크게 company(주식회사), AI(주식을 사고파는 임의에 사람들), User_stock(사용자)로 구성되어 있다.
 
<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/177317758-da0647cc-e5be-4a2b-9aa8-4ff4e66766e3.PNG">

ai는 주식을 사고사는 사람들을 임의로 정해 둔 것으로 가지고 있는 돈에 따라 flex집단, rich집단, normal집단, poor집단으로 구성되어 있다. 각각의 이름 및 아이디는 임의로 정하였고, 번호가 1~5번인 사람은 10억(flex)에 해당하고, 6번에서 10번인 사람은 5억(rich)에 해당하고, 11번에서 26번인 사람은 1천만원(normal)에 해당하고, 27번에서 35번인 사람은 1백만원(poor)에 해당한다. 각각 아이디 및 가지고 있는 주식, 주식의 개수, 자산 등으로 테이블을 구성했다. flex_ai가 주식을 살 확률은 1%이다. poor_ai로 내려 갈때마다 주식을 살 확률이 늘어난다. ai가 가지고 있는 돈과 주가를 비교하여 주식을 사게 되는데 한 번 주식을 살 때마다 700개씩 산다. 이는 poor_ai로 갈수록 축소된다. 그렇기 때문에 flex_ai가 움직이게 되면 주가에 큰 변동이 있다. ai는 주식을 사는 행동을 확률로 사기 때문에 그 확률에 미치지 못했다고 해서 페이지가 만료 되면 안되기 때문에 페이지를 계속 새로고침 하면서 계속해서 작동을 한다. 사용자는 첫 로그인을 하면 100만원으로 주식을 사고 팔 수 있다.  
___

# 3.전자회로 실험

<img width="891" alt="1" src="https://user-images.githubusercontent.com/79968300/178684918-900b7f32-ecd6-4761-a91a-33f737835388.PNG">

2학년 1학기 전자회로를 수강했다. 직접 만든 회로를 직접 프로그래밍하여 하나의 완성품을 만들어다. 따라서 옴의 법칙부터 다이오드, 트랜지스터의 원리와 특성, 기자재 사용방법 등 실습의 기초가 되는 지식들을 공부했다. 소자와 기자재들을 이용해 이론들을 검증하는 과정에서 오히려 수업을 들을 때 이해가 되지 않던 개념들을 실습을 통해 이해하는 경우도 있었다. 실습결과를 보고서로 작성하면서 공학도들은 정확한 수치를 바탕으로 보고서를 작성하는 것이 중요하다고 느꼈다. 이 수업을 바탕으로 하드웨어에 대한 이해를 할 수 있었다.

___

# 4.통신시스템 설계

K=4 짜리 Convolutional Encoder와 Decoder를 Python으로 프로그래밍 하는 프로젝트를 구현하였다. K=3짜리인 경우와 K=4짜리인 경우에 QPSK의 BER이 0db~8db 까지 그려지도록 프로그래밍 했다.

<img width="500" alt="12" src="https://user-images.githubusercontent.com/79968300/178689226-451604fe-55bf-4a56-af7d-095142011c20.PNG">

다음 두 그림은 data_size = 1000000 이고, max_snr = 9 로 총 10번 돌아가는 k=4와 k=3 결과 화면이다. 왼쪽 그림이 k=4이고, 오른쪽 그림이 k=3 그래프다. 그림에서 볼수 있듯이 data_size 값과 max_snr값을 고정 시켰음에도 불구하고 k=4인 경우에는 y축이 10^-5 이상으로 그래프가 그려지고, k=3인 경우는 10^-5에 가깝거나 조금 멀게 그려진다. 그래프 자체도 k=4 그래프는 곡선형으로 완만하게 떨어지고 k=3 그래프는 k=4 그래프에 비해 찌그러진 곡선 모양이다. 이는 k=4 그래프가 더 성능이 좋다고 볼 수 있다. 이러한 결과가 나온 이유는 인코딩과 디코딩 과정을 거치는 비트의 수가 늘어났기 때문이다. 인터리버를 추가로 구현하지 못했지만 인터리버를 통해 비트를 재배열 하는 과정을 거친다면 ber 그래프가 좀 더 곡선형으로 보일 것이며 오류 검출 및 수정 과정도 더 원만하게 이루어졌을 것으로 예상 된다.  


___

# 5.데이터베이스 설계

데이터베이스 설계 프로젝트 주제는 야구로 설정했다. 타자, 투수 테이블을 조인하여 2020년에 롯데 상대로 강했던 타자, 롯데 상대로 강했던 투수 테이블을 METRICS 테이블로 생성한다. 그 테이블을 통하여 2020년 롯데 상대 전적을 만들고, 이렇게 파악한 데이터를 바탕으로 2021년에 롯데 상대로 팀 RANKING테이블을 생성하여 2021년에는 롯데 상대로 어떤 팀이 강하고 어떤 팀이 약한지 예측하는 테이블을 생성했다. 데이터를 가져오기 위해서 http://www.kbreport.com/main 를 이용하여 데이터를 엑셀파일로 수정하여 IMPORT 하였다. 

<img width="700" alt="1" src="https://user-images.githubusercontent.com/79968300/178698433-f995566c-052a-4194-859a-ede31401ea25.PNG">

다음 데이터베이스는 2020년 롯데 상대전적이다. 이 표를 참고하면 가장 신빙성이 있는 데이터를 크게 투수 부분과 타자 부분으로 나우어 추출한다. 투수 부분은 RA9_WAR(9이닝당 투수 WAR수치) 데이터와 ERA(평균 자책점) 데이터를 사용한다. 타자 부분은 WRC(조정 득점 창출력 즉 득점을 만들어낼 수 있는 능력)데이터와 WOBA(전체적인 공격 기여도)를 사용하여 데이터를 창출한다. 2020년 롯데 상대 전적 데이터를 분석해보면 NC와 KIA가 공동 1등인 것을 볼 수 있다. NC는 타자 데이터가 투수 데이터를 압살 할 정도로 높고, KIA는 타자 데이터와 투수 데이터 모두 준수하다고 볼 수 있다. 또, 상위권에 위치한 두산 역시 타자 데이터, 투수 데이터 모두 준수한 성적을 냈다. 삼성, SSG, 키움 팀은 4위에 위치한것을 볼 수 있는데 3팀 모두 BAKANCE형으로 투수와 타자 성적을 합쳐서 봤을 때 어떤 팀은 투수가 강하지만 타자가 약하고, 반대로 타자가 강하지만 투수가 강함으로써 상쇄되는 것을 볼 수 있다. 6팀이 롯데보다 강하거나 비슷했다. 롯데보다 약했던 3팀은 LG, KT, 한화로 LG는 투수가 평균 수준이지만 그에 반해 타자가 너무 약했다는 것을 확인할 수 있고, KT는 타자가 강했지만 투수가 평균 이하 수준으로 약했다는 것을 확인할 수 있다. 한화는 모든 수치가 최하수치이므로 9등인 것을 확인할 수 있다.

<img width="500" alt="1" src="https://user-images.githubusercontent.com/79968300/178700189-f48ed076-3389-4333-8c7d-4b99db67672f.PNG">

다음 표는 가공된 데이터를 이용한 각 팀 수치이다. 각 데이터를 분석 하면 NC는 투수력이 하위권 수준이지만 타자 데이터가 상당히 높은 것을 확인할 수 있다. 하지만 작년과 비교하면 공격력은 비스하지만 투수력이 더 낮아졌다. 두산은 투수력과 공격력 모두 상위권인 것을 확인할 수 있다. KIA는 공격력 투수력 모두 준수한 것을 볼 수 있다. KT는 평균 자책점은 약하지만 나머지 부분이 상위권에 랭크 되어있다. 삼성은 투수력이 좋고 타자가 약하며 LG는 투수와 타자가 조화를 이루고 있다. SSG와 키움은 투수, 타자 모두 낮은 편인 것을 확인할 수 있다. 한화는 작년과 마찬가지로 모두 하위권이다. 

<img width="500" alt="2" src="https://user-images.githubusercontent.com/79968300/178700837-8cd8a825-6b96-4dc6-a06f-2da7bd268481.PNG">

따라서 2021년 롯데 자이언츠에 상대 RANKING 시스템은 다음과 같이 예측했다.

___

# 6.임베디드 시스템 설계

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

1) cat
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
 

2) pwd

char* getcwd(char* buf,size_t size);
void pwd(void){
	char buf[100];
	getcwd(buf,100);
	printf("%s \n",buf);
}

 Minishell에서 사용자가 입력한 값이 pwd이면 pwd 함수를 호출한다. pwd 함수는 getcwd 함수를 이용하여 만들었다. 여기서 getcwd는 작업 중인 디렉토리 이름을 가져오는 기능이고, (char *buf, size_t size) 중 buf는 작업중인 디렉토리의 이름을 담을 버퍼이다. size_t size는 버퍼의 크기이다. 이 함수의 return 값은 현재 작업중인 디렉토리를 반환하므로 pwd 함수에서 getcwd 함수를 호출하여 완성된다.







3) cd 
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

 Minishell에서 사용자가 입력한 값이 cd이면 cd함수를 호출한다. chdir(경로)를 사용한 결과 0이 나오면 경로 이동이 성공한다. 만약 0이 아니라면 변경에 실패한다.

4) mkdir
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

 Minishell에서 사용자가 입력한 값이 mkdir 이면 mk 함수를 호출한다. 여기서 read는 경로 입력이고, write는 디렉터리 생성 성공과 실패를 출력한다. mkdir는 디렉터리를 생성 하고 성공시 0을 반환한다. 먼저 read 함수로 경로를 입력받는다. read 함수는 입력받은 문자열에 자동으로 개행 문자가 들어가게 된다. 경로에는 개행 문자(\n)가 들어갈 수 없기 때문에 제거한다. while문을 이용해서 개행 문자를 찾으면 0으로 값을 변경하도록 한다. mkdir에 기본 함수 형은 mkdir(경로 이름, 권한) 이다. 디렉터리의 기본 권한은 755 이므로 result에 경로와 0755를 넣는다. 마지막 부분에는 디렉터리를 생성해서 반환 값에 따라 메시지를 출력한다.


5) ls
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
 
 Minishell에서 사용자가 ls를 입력하였을 때 ls 함수를 호출한다. ls는 기본적으로 opendir함수와 readdir 함수를 사용한다. opendir 함수는 매개변수에 해당하는 디렉토리 스트림을 열고 그 디렉토리 스트림에 대한 포인터를 반환한다. readdir 함수는 dirent 구조체 내에 있는 디렉토리 내용을 읽는다. 먼저 동적 메모리 할당을 하고, dirent 구조체에 접근한다. dirent 구조체는 파일, 또는 디렉토리가 가지고 있는 정보 구조체이다. 여기서 파일을 read할 때 파일명 앞에 .이 붙어있다면 히든 파일이다. 그 히든 파일을 숨기기 위해 entry->d_name[0] 값이 . 이라면 continue 시켜 출력 시키지 않는다.

   
6) history
	scanf("%s",buffer);
		words[n] = strdups(buffer);
		n++;
		if(strcmp(buffer,"history")==0){
			for(int i = 0 ; i<n; i++)
				printf("[%d] %s\n",i+1,words[i]);
			scanf("%s",his);

 
 history는 따로 함수를 만들지 않고, main문에서 사용자가 명령어 또는 값을 입력할 때마다 strdups함수를 사용하여 words 포인터 배열 변수에 저장한다. 만약 사용자가 history를 입력하면 words 배열에 있는 값들을 모두 출력한다. 

7) ![number] history
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
 
사용자가 history를 입력한다면 scnaf 함수를 다시 사용하여 !숫자 값을 받기를 기다린다. his라는 배열을 이용하여 만약 his[0]이 !라면 ![number] 기능을 사용한다는 뜻이기 때문에 함수가 동작한다. 먼저 포인터 문자 변수에 strtok를 사용하여 !를 제외한 값을 저장한다. 그리고 그 값을 atoi함수를 통해 문자열을 정수로 바꾼다. words[n]은 0부터 시작하기 때문에 words[n-1]이 사용자가 원하는 값이 된다. 그 값을 출력하고, strcpy를 통해 buffer에 문자열 복사를 한다. buffer에 복사된 값을 명령어들과 하나씩 비교하여 만약 그 명령어가 있다면 수행한다.  

8) ps
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

  pid값을 얻기 위해서는 getpid()와 getppid() 함수를 사용한다. 디렉토리 이름이 proc/pid/cmdiline 이라면 프로세스 이름을 알 수 있다. 이 때 부모 프로세스에 pid 값과 자식 프로세스에 pid 값을 이용한다. while문을 통하여 /proc에 존재하는 파일들을 차례대로 읽는다. 그리고 pid3 변수에 숫자로 반환한다. /proc/pid/cmdline에서 프로세스의 이름을 가져오는 함수로 보낸다. getCmdLine에서는 tempPath값과 cmdline값을 받아서 모든 값을 반환한다. 여기서 부모 프로세스 pid 값과 자식 프로세스 pid 값을 이용하여 출력한다.
 
9) cp

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
 
 cp는 명령어를 동작할 때 scnaf(“%s%s”)로 2개의 값을 받는다. 변수 src에 복사 할 파일을 RDONLY를 사용해 읽기 전용으로 open한다. 변수 dst에는 새로 생성될 파일에 O_WRONLY | O_CREAT | O_TRUNC, 0644 를 사용해 소유자는 읽기/쓰기가 가능하며, 나머지 모든 사람은 읽기만 가능하게 한다.

10) rm

void rm(){
	char name[30];
	scanf("%s",&name);

	int nResult = remove(name);
	if(nResult == -1){
		printf("fail\n");
	}
}

 사용자가 rm을 입력하면 rm 함수가 동작한다. scanf를 통해 삭제시킬 명령어를 받는다. remove 함수를 사용하여 파일을 삭제한다. unlink는 비어있는 디렉토리는 에러가 나지만 remove 함수는 비어있는 디렉토리도 삭제가 가능하다. 만약 nResult 값이 –1을 반환한다면 삭제에 실패한 것이다. 

11) ln

void ln(){	
	char a[30];
	char b[30];
	scanf("%s %s",a,b);
	link(a,b);
}

 사용자에게 link로 연결할 값을 scanf를 통해 2개로 받는다. 그 값을 link를 통해 하드링크로 생성한다.

12) stat
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

13) chmod

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

 mode로 입력받는 8진수는 맨 앞 자리는 사용자, 두 번째는 그룹, 세 번째는 나머지를 의미하며 4는 읽기, 2는 쓰기 1은 실행 권한을 의미한다. 리눅스에서 access 함수를 사용하여 함수로 파일에 읽기, 쓰기, 실행 권한이 존재하는지 확인할 수 있다. F_OK는 파일 존재 여부 확인으로 실패 시 –1을 리턴 하고, 성공 시 0을 리턴 한다. chmod 함수에 접근하여 만약 반환값이 0이 아니라면 실패한다. 

 





14) alias
 
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

 먼저 구조체 배열을 선언한다. 구조체 배열에는 fake_name[100] (별명) real_name[100] (명령어) 로 구성한다. 만약 사용자가 alias를 입력한다면 scanf를 통해 a=’ls’ 값을 받는다. 여기서 먼저 sscnaf를 통해 =을 기준으로 앞에 있는 값을 fake_name[k]에 저장한다. 여기서 k값은 무한 반복문이 수행되기 전에 0으로 초기화 되어 있고, alias가 수행된다면 k++로 값을 늘려준다. =으로 자르고 남은 ‘ls’ 값을 strtok을 통하여 작은 따옴표를 분리하여 real_name[k]에 저장한다. 반복문을 통해 사용자가 명령어를 입력할 때 만약 별명 배열에 저장되어 있는 값과 똑같고 실제 명령어 배열에 Minishell에 구현되어 있는 명령어 중 하나가 있다면 동작하게 된다. 

15) exit

   만약 사용자가 exit를 입력하면 break를 통해 무한 반복문을 끝낸다.

___

## 7. 각 클래스 기능별 설명

|클래스|기능|layout|
|------|---|---|
|AddressActivity.java|구글맵 api를 사용한 위치확인|activity_adress.xml|
|Board_Module.java|게시글관련 데이터들의 클래스화|x|
|Chat_Module.java|채팅관련 데이터들의 클래스화|x|
|Chatting_Fragment.java|채팅방 보기|chatting_fragment.xml|
|ChattingAdapter.java|Chatting_Fragment RecyclerView에 들어갈 어댑터|x|
|ChattingContentData.java|ChattingAdapter 들어갈 컴포넌트 클래스화|x|
|ChattingRecordMoudule.java|채팅기록관련 데이터들의 클래스화|x|
|CustomCareActivity.java|고객센터 Activity|activity_custom_care.xml|
|FinalURLIP.java|서버 ,port주소설정|x|
|GMailSender.java|학번 인증번호 전송관련 라이브러리|x|
|GpsTracker.java|GPS관련 라이브러리|x|
|GuideActivity.java|전체 가이드라인 설정|activity_guide.xml|
|Guide_First.java|가이드라인1|guide_line_first.xml|
|Guide_second.java|가이드라인2|guide_line_second.xml|
|Guide_third.java|가이드라인3|guide_line_third.xml|
|Guide_Fourth.java|가이드라인4|guide_line_fourth.xml|
|Guide_Five.java|가이드라인5|guide_line_five.xml|
|InsetBoardActivity.java|게시판에 글쓰기 화면|activity_insert_board.xml|
|LoginActivity.java|로그인 화면|activity_login.xml|
|MainActivity.java|메인 화면|activity_main.xml|
|MainAdapter.java|MainActivity RecyclerView에 들어갈 어댑터|x|
|MainBoard_Fragment.java|게시판목록보기화면|mainboard_fragment.xml|
|MainData.java|MainAdapter에 들어갈 컴포넌트 클래스화|x|
|MembershipActivity.java|회원가입 화면|activity_membership.xml|
|MenuList_Fragment.java|주문목록 화면|menulist_fragment.xml|
|MyInfo_Fragment.java|내정보 화면|myinfo_fragment.xml|
|MyService.java|양방향 통신을 하기위한 안드로이드 Service|x|
|NoticeAdapter.java|NotifyActivity RecyclerView에 들어갈 어댑터|x|
|NoticeData.java|NoticeAdapter에 들어갈 컴포넌트 클래스화|x|
|Notify_Module.java|공지관련 데이터들의 클래스화|x|
|NotifyActivity.java|공지사항 화면|activity_notify.xml|
|RequestHttpURLConnection.java|단방향통신을 하기위한 라이브러리|x|
|SignatureUtil.java|해시코드로 변환하기위한 라이브러리|x|
|Splash.java|앱 실행시 Splash Animation|splash.xml|
|User_Module.java|유저관련 데이터들의 클래스화|x|

Server
|클래스|기능|
|------|---|
|Board_Module.java|게시물 관련 데이터 클래스화|
|Custom_Module.java|고객센터 문의 관련 데이터 클래스화|
|Chat_Module.java|채팅 메세지 데이터 클래스화|
|Server_Module.java|소켓 프로그래밍(채팅) 데이터 클래스화|
|Notify_Module.java|공지사항 게시물 관련 데이터 클래스화|
|BoardDAO.java|게시물 데이터베이스에 접근 클래스
|ChatDAO.java|채팅 기록 데이터베이스 접근 클래스|
|ChatListDAO.java|채팅 목록 데이터베이스 접근 클래스|
|CustomCareDAO.java|고객센터 문의글 데이터베이스 접근 클래스|
|NotifyDAO.java|공지사항 데이터베이스 접근 클래스|
|userDAO|로그인, 회원가입 등 유저 정보 데이터베이스 접근 클래스|

Servlet
|Servlet|Request|Response|DBUpdate|
|------|---|---|---|
|CallChattingRoomDateServelt.java|서비스 제공자/이용자 ID |채팅 기록|x|
|ChangePWServlet.java|유저ID, 변경할PW|x|새로운PW DB저장||
|CustomReportServlet.java|고객센터 신고 데이터|x|신고글 DB저장|
|EditProgressServlet.java|주문ID,접수ID|x|주문의 진행상태 변경|
|InsertChattingRoomServlet.java|주문ID,접수ID|x|채팅목록DB 유저 추가|
|IsThereIDServlet.java|입력ID|ID중복여부|x|
|LoadOnBoardServlet.java|요청 parameter|모든 주문게시글 데이터|x|
|LoadOwnOrdersServlet.java|유저ID|유저의 주문목록 데이터|x|
|LoginConfirmServlet.java|유저ID, 유저PW|ID,PW 일치여부|x|
|NotifyReceiverServlet.java|공지사항 데이터|x|공지사항 DB저장|
|NotifySenderServlet.java|요청 parameter|공지사항 데이터|x|
|OrderCancelServlet.java|주문고유번호|x|지정된 주문목록DB에서 삭제|
|OrderCompltedServlet.java|주문고유번호|x|주문상태완료로 변경|
|OrdererErranderIDServlet.java|유저ID|채팅상대ID|x|
|PostOnBoardServlet.java|주문게시글 데이터|x|주문목록DB에 주문추가|
|RegisterUserServlet.java|회원가입양식 데이터|x|유저DB에 회원정보추가|
|ShowUserInfoServlet.java|유저ID|유저의 회원정보|x|
|SignatureUtilServlet.java|입력 PW|x|회원정보 입력 전 비밀번호 암호화|
___

## 8. 개발 과정

     Week5.
           김준혁, 옥석우 - 구글맵활용 GPS로 현위치 찾기
           김형진 - 회원가입 및 로그인 서버환경 구축
           마건우 - 초기 데이터베이스 스키마 설계
           차형석 - 회원가입 및 로그인 액티비티 구현
           
     Week6.
           김준혁 - 메인 화면 구축(로그아웃, 회원정보 변경)
           김형진 - 게시글 관련 서블릿
           마건우 - 게시글 등록
           옥석우 - 게시글 새로고침 기능
           차형석 - 게시글 관련된 main adapter 구현
           
     Week7.
           김준혁 - 게시글 펼쳐보기/수락 기능구현
           김형진 - 주문 수락 및 취소,불러오기 서블릿
           마건우 - 주문목록 구현
           옥석우 - 주문 취소 구현
           차형석 - 프래그먼트 구현
           
     Week8.
           김준혁 - 고객센터 신고접수 기능 구현 
           김형진 - 고객센터 신고접수, 공지사항 불러오기/등록하기
           옥석우 - 가이드라인 기능 구현 
           마건우 - 게시글 세부 분류 
           차형석 - 공지사항 추가 및 게시
           
     Week9.
           김준혁 - 스플래쉬스크린 
           김형진 - 채팅관련 서블릿
           마건우 - 주문목록 변경, 메인게시판 정리
           옥석우,차형석 - 채팅 액티비티, 채팅프래그먼트(채팅목록)
           
     Week10.
           김준혁 - 채팅방 레이아웃
           김형진,옥석우 - 비동기 서버 구현을 위한 학습 및 제작진행
           마건우 - 채팅기능에서 필요한 데이터 검토, 채팅 액티비티
           차형석 - 안드로이드 서비스 구현
          
     Week11.
           김준혁, 마건우, 옥석우  - 디자인
           김형진 - Servlet과는 독립적으로 동작하는 서버소켓 및 쓰레드 비동기 구현 중
           차형석 - 서비스 안에 쓰레드 구현
          
     Week12.
           김준혁 - 고객센터 디자인
           김형진 - 비동기 채팅서버 구현 및 비동기 서버와 기존 단방향 통신 서버 병합 작업
           마건우 - 채팅방 어댑터 구현
           옥석우 - 공지사항 툴바 및 내용 디자인
           차형석 - 글쓰기 디자인 및 안드로이드 서비스내 소켓통신 관련 동작 재정의
          
     Week13. 
         김형진
        - LoginActivity 회원가입 버튼 및 margin 관련 디자인 보완
        - MainActivity 의 글쓰기 Button 디자인 / Fragment 관련 UI 수정, fragment button을 삭제하고 bottomNavigationView를 추가

        김준혁
        - LoginActivty 로고 사이즈 조절 및 UI수정
        - MembershipActivty UI 수정 및 성별 선택란 EditText -> RadioButton으로 수정
        - myinfo_fragment UI 수정

        마건우
        -Chattingactivity의 content크기 조절및 위치조정/말풍선크기 조절, 지도와 연결된 네비게이션 버튼 구현
        -말풍선을 wrapcontent로 설정후 min 값을 설정하여 텍스트가 작은상황에서 말풍선의 최소크기값을 설정
        -Adapter에서 말풍선이 send인지 receive인지 구분하기위해 조건에따라 출력되는 채팅 아이템의 layout을 다르게 설정
        -Chattingactivity에서 네비게이션 버튼을 이용하여 구글맵과 연관된 Addressactivity로의 이동을 인텐트으로 구현

        옥석우
        - activity_notice.xml의 전체적인 디자인 수정 (notice 로고를 넣고, 시간 .으로 세분화 및 우측 정렬과 공지사항에 각 number부여 
         공지사항의 제목은 center정렬)
        - activity_custom_care.xml의 전체적인 디자인 수정 (체크 박스를 전체적으로 가운데로 모으고, textcolor는 black으로 통일,
         신고 제목과 신고하려는 상대 아이디를 입력할 수 있도록 수정)

        차형석 
        - 안드로이드, 서버단에 강제 종료시 상황 구현
        - global server를 위해 도메인과 서버연동중
        - ChattingFragment를 없애고 ChattingActivity로 변경
        - 실시간 채팅과 채팅방 대화기록유지, 채팅상대가 없을때 상황등 각각의 채팅상황에 대한 UI, UX 구현

___

## 9. 각 클래스별 코드설명
 - LoginActivity(로그인)
 
 ```java
 public class LoginActivity extends AppCompatActivity implements View.OnClickListener {

    EditText IDEditText;
    EditText PWEditText;
    Button LoginConfirmBtn;
    Button MoveMembershipBtn;

    public Toolbar LoginToolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        LoginToolbar = findViewById(R.id.LoginToolbar);
        LoginToolbar.setTitle("");
        setSupportActionBar(LoginToolbar);

        IDEditText = findViewById(R.id.IDEditText);
        PWEditText = findViewById(R.id.PWEditText);
        LoginConfirmBtn = findViewById(R.id.LoginConfirmBtn);
        MoveMembershipBtn = findViewById(R.id.MoveMembershipBtn);

        LoginConfirmBtn.setOnClickListener(this);
        MoveMembershipBtn.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.LoginConfirmBtn :{
                //서버에 보낼거
                ContentValues values = new ContentValues();
                values.put("userID", IDEditText.getText().toString());
                values.put("userPassword", SignatureUtil.applySHA256(PWEditText.getText().toString()));

                String response = "";
                NetworkTask networkTask = new NetworkTask(resulturl("LoginConfirmServlet"), values);
                try {
                    response = networkTask.execute().get();
                    Log.d("",response);
                } catch (ExecutionException e) {
                    e.printStackTrace();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                if(response.equals("1")){
                    onStartService();
                    Intent intent = new Intent(LoginActivity.this , MainActivity.class);
                    intent.putExtra("userID",IDEditText.getText().toString());
                    startActivity(intent);
                }
                else{
                    //로그인 실패!
                    Log.d("","login failed");
                }

                break;
            }
            case R.id.MoveMembershipBtn : {
                Intent intent = new Intent(LoginActivity.this,MembershipActivity.class);
                startActivity(intent);
                break;
            }
            default: {
                break;
            }
        }
    }

    public void onStartService(){
        Intent intent = new Intent(this, MyService.class);
        intent.setAction("Access"+IDEditText.getText().toString());
        startService(intent);
    }

    // Service 종료시킬 때, 사용하면 됨
    public void onStopService(){
        Intent intent = new Intent(this, MyService.class);
        stopService(intent);
    }

    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }

    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
 ```
- MembershipActivity(회원가입)

 ```java
public class MembershipActivity extends AppCompatActivity implements View.OnClickListener {

    private Boolean IDOverlapStatus = false;
    private Boolean StudentIDAuthenticateStatus = false;
    private String localIDStorage = "";
    private String userEmail = "";

    public Toolbar memberToolbar;

    EditText NameMemberText;
    EditText IDMemberText;
    EditText PWMemberText;
    EditText PWConfirmMemberText;
    EditText StudentIDMemberText;
    EditText MajorMemberText;
    EditText EmailAuthenticateEditText;

    User_Module userModule;
    Button MoveLoginBtn;
    Button FinishMemberShipBtn;
    Button OverlapConfirmBtn;
    Button StudentIDAuthenticateBtn;
    Button StudentIDConfirmBtn;
    RadioButton GenderMan,GenderWomen;
    RadioGroup GenderSelect;
    String GenderText = "";



    //이메일 인증관련 변수
    long seed = System.currentTimeMillis();
    Random random = new Random(seed);
    int randomNum = 0;

    String Email = "xodus374@gmail.com";
    String password = "gyhmpooddhfhbvpz";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_membership);

        memberToolbar = findViewById(R.id.MemberToolbar);
        memberToolbar.setTitle(R.string.defaultToolbar);
        setSupportActionBar(memberToolbar);

        NameMemberText = findViewById(R.id.NameMemberText);
        IDMemberText = findViewById(R.id.IDMemberText);
        PWMemberText = findViewById(R.id.PWMemberText);
        PWConfirmMemberText = findViewById(R.id.PWConfirmMemberText);
        StudentIDMemberText = findViewById(R.id.StudentIDMemberText);
        GenderMan = findViewById(R.id.GenderMan);
        GenderWomen = findViewById(R.id.GenderWomen);
        GenderSelect = findViewById(R.id.GenderSelect);
        MajorMemberText = findViewById(R.id.MajorMemberText);
        EmailAuthenticateEditText = findViewById(R.id.EmailAuthenticateEditText);

        MoveLoginBtn = findViewById(R.id.MoveLoginBtn);
        FinishMemberShipBtn = findViewById(R.id.FinishMemberShipBtn);
        OverlapConfirmBtn = findViewById(R.id.OverlapConfirmBtn);
        StudentIDAuthenticateBtn = findViewById(R.id.StudentIDAuthenticateBtn);
        StudentIDConfirmBtn = findViewById(R.id.StudentIDConfirmBtn);

        MoveLoginBtn.setOnClickListener(this);
        FinishMemberShipBtn.setOnClickListener(this);
        OverlapConfirmBtn.setOnClickListener(this);
        StudentIDAuthenticateBtn.setOnClickListener(this);
        StudentIDConfirmBtn.setOnClickListener(this);
        GenderSelect.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int gender) {
                if(gender == R.id.GenderMan){
                    GenderText = "male";
                } else if (gender == R.id.GenderWomen){
                    GenderText = "female";
                }
            }
        });

        StrictMode.setThreadPolicy(new StrictMode.ThreadPolicy.Builder()
                .permitDiskReads()
                .permitDiskWrites()
                .permitNetwork().build());
        Spinner spinner = (Spinner)findViewById(R.id.spinner);
        MajorMemberText.setText("");
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener(){
            @Override
            public void onItemSelected(AdapterView<?> parent,View view, int position, long id){
                MajorMemberText.setText(""+parent.getItemAtPosition(position));
            }
            @Override
            public void onNothingSelected(AdapterView<?> parent){}
        });
    }



    @Override
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.OverlapConfirmBtn : {

                ContentValues values = new ContentValues();
                values.put("inputID", IDMemberText.getText().toString());

                String response = "";
                NetworkTask networkTask = new NetworkTask(resulturl("IsThereIDServlet"), values);
                try {
                    response = networkTask.execute().get();
                    Log.d("",response);
                } catch (ExecutionException e) {
                    e.printStackTrace();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }

                if(response.equals("1")){
                    Toast.makeText(getApplicationContext(),"이미있는 아이디 입니다.",Toast.LENGTH_SHORT).show();
                }
                else{
                    IDOverlapStatus = true;
                    Toast.makeText(getApplicationContext(),"중복확인이 되었습니다.",Toast.LENGTH_SHORT).show();
                    localIDStorage = IDMemberText.getText().toString();
                }

                break;
            }
            case R.id.StudentIDAuthenticateBtn : {
                ContentValues values = new ContentValues();
                values.put("InputStudentNumber", StudentIDMemberText.getText().toString());

                String response = "";
                NetworkTask networkTask = new NetworkTask(resulturl("IsThereStudentNumberServlet"), values);
                try {
                    response = networkTask.execute().get();
                    Log.d("",response);
                } catch (ExecutionException e) {
                    e.printStackTrace();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                if(response.equals("1")){
                    Log.d("", "중복됨");
                    Toast.makeText(getApplicationContext(),"이미 등록된 회원의 학번입니다.",Toast.LENGTH_SHORT).show();
                }
                else{
                    Log.d("", "중복안됨");
                    Toast.makeText(getApplicationContext(),StudentIDMemberText.getText().toString() + "@sangmyung.kr 로 인증번호를 발송합니다.",Toast.LENGTH_SHORT).show();
                    randomNum = random.nextInt(10000000);
                    userEmail = StudentIDMemberText.getText().toString() + "@sangmyung.kr";

                    Log.d("",randomNum+"");
                    try {
                        GMailSender gMailSender = new GMailSender(Email, password);
                        gMailSender.sendMail("갖다드림 학번인증키입니다.",String.valueOf(randomNum) , userEmail);//SignatureUtil.applySHA256(String.valueOf(randomNum))
                        Toast.makeText(getApplicationContext(), "해당 이메일로 보낸 인증코드를 아래에 입력해주세요.", Toast.LENGTH_SHORT).show();
                    } catch (SendFailedException e) {
                        Toast.makeText(getApplicationContext(), "이메일 형식이 잘못되었습니다.", Toast.LENGTH_SHORT).show();
                    } catch (MessagingException e) {
                        Toast.makeText(getApplicationContext(), "인터넷 연결을 확인해주십시오", Toast.LENGTH_SHORT).show();
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                }
                break;
            }
            case R.id.StudentIDConfirmBtn : {
                if(String.valueOf(randomNum).equals(EmailAuthenticateEditText.getText().toString())){
                    Toast.makeText(getApplicationContext(),"인증코드가 맞습니다.",Toast.LENGTH_SHORT).show();
                    StudentIDAuthenticateStatus = true;
                    StudentIDMemberText.setInputType(InputType.TYPE_NULL);
                    EmailAuthenticateEditText.setInputType(InputType.TYPE_NULL);
                    StudentIDAuthenticateBtn.setClickable(false);
                    StudentIDConfirmBtn.setClickable(false);
                }
                else{
                    Toast.makeText(getApplicationContext(),"인증코드가 맞지않습니다.",Toast.LENGTH_SHORT).show();;
                    StudentIDMemberText.setText("");
                    EmailAuthenticateEditText.setText("");
                }
                break;
            }
            case R.id.MoveLoginBtn : {
                Intent intent = new Intent(MembershipActivity.this,LoginActivity.class);
                startActivity(intent);
                break;
            }
            case R.id.FinishMemberShipBtn : {
                if(!PWMemberText.getText().toString().equals(PWConfirmMemberText.getText().toString()) || PWMemberText.getText().equals("")) {
                    PWMemberText.setText("");
                    PWConfirmMemberText.setText("");
                    Toast.makeText(getApplicationContext(),"비밀번호가 없거나 같지않습니다.",Toast.LENGTH_SHORT).show();
                }
                else{
                    if(NameMemberText.getText().toString().equals("")){
                        Toast.makeText(getApplicationContext(),"이름을 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        NameMemberText.requestFocus();
                    }
                    else if(IDMemberText.getText().toString().equals("")){
                        Toast.makeText(getApplicationContext(),"아이디를 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        IDMemberText.requestFocus();
                    }
                    else if(!IDOverlapStatus){
                        Toast.makeText(getApplicationContext(),"아이디 중복확인을 해주세요.",Toast.LENGTH_SHORT).show();
                    }
                    else if(!localIDStorage.equals(IDMemberText.getText().toString())){
                        Toast.makeText(getApplicationContext(),"중복확인한 아이디로 입력해주세요.",Toast.LENGTH_SHORT).show();
                        IDMemberText.setText("");
                        IDMemberText.requestFocus();
                    }
                    else if(PWMemberText.getText().toString().equals("")){
                        Toast.makeText(getApplicationContext(),"비밀번호를 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        PWMemberText.requestFocus();
                    }
                    else if(PWConfirmMemberText.getText().toString().equals("")){
                        Toast.makeText(getApplicationContext(),"비밀번호확인을 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        PWConfirmMemberText.requestFocus();
                    }
                    else if(!StudentIDAuthenticateStatus){
                        Toast.makeText(getApplicationContext(),"학교인증을 받아주세요",Toast.LENGTH_SHORT).show();;
                    }
                    else if(GenderText.equals("")){
                        Toast.makeText(getApplicationContext(),"성별을 선택해주세요.",Toast.LENGTH_SHORT).show();;
                    }
                    else if(MajorMemberText.getText().toString().equals("")){
                        Toast.makeText(getApplicationContext(),"학과를 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        MajorMemberText.requestFocus();
                    }
                    else{
                        ContentValues values = new ContentValues();
                        values.put("Regi_id", IDMemberText.getText().toString());
                        values.put("Regi_pass",  SignatureUtil.applySHA256(PWMemberText.getText().toString()));
                        values.put("Regi_name", NameMemberText.getText().toString());
                        values.put("Regi_major", MajorMemberText.getText().toString());
                        values.put("Regi_school_number", StudentIDMemberText.getText().toString());
                        values.put("Regi_gender", GenderText);

                        NetworkTask networkTask = new NetworkTask(resulturl("RegisterUserServlet"), values);
                        networkTask.execute();

                        Intent intent = new Intent(MembershipActivity.this,LoginActivity.class);
                        startActivity(intent);
                    }
                }
            }
//            case R.id.FindMajorBtn: {
//
//            }

            default: {
                break;
            }
        }
    }
    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }

    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
 ```
- MainBoard_Fragment(메인)

 ```java
public class MainBoard_Fragment extends Fragment {

    public Button BoardInBtn;
    public View view;
    public Toolbar mainToolbar;
    public ArrayList<Board_Module> boardsArray = new ArrayList<Board_Module>();;
    public Board_Module boards;
    public String[] JsonList = new String[50];;

    private ArrayList<MainData> dataList;
    private MainAdapter mainAdapter;
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager;
    private SwipeRefreshLayout swipeLayout;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.mainboard_fragment, container, false);
        setHasOptionsMenu(true);

        swipeLayout = view.findViewById(R.id.swipe_container);
        mainToolbar = view.findViewById(R.id.mainToolbar);
        mainToolbar.setTitle(R.string.mainToolbar);
        ((AppCompatActivity)getActivity()).setSupportActionBar(mainToolbar);

        recyclerView = view.findViewById(R.id.rv);
        linearLayoutManager = new LinearLayoutManager(view.getContext());
        recyclerView.setLayoutManager(linearLayoutManager);
    

        dataList = new ArrayList<>();
        mainAdapter = new MainAdapter(dataList);
        recyclerView.setAdapter(mainAdapter);
        getBoard();
        for(int i=dataList.size()-1;i>=0;i--){
            if(!dataList.get(i).getErrandProgress().equals("@@Waiting") || dataList.get(i).getOrderID().equals(MainActivity.userID)){
                dataList.remove(i);
            }
        }
        mainAdapter.notifyDataSetChanged();

        swipeLayout.setOnRefreshListener(new SwipeRefreshLayout.OnRefreshListener() {
            @Override
            public void onRefresh() {
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Waiting")|| dataList.get(i).getOrderID().equals(MainActivity.userID)){
                        dataList.remove(i);
                    }
                }
                new Handler().postDelayed(new Runnable() {
                    @Override public void run() {
                        swipeLayout.setRefreshing(false);
                    }
                }, 1000);
                mainAdapter.notifyDataSetChanged();
            }
        });

        BoardInBtn = view.findViewById(R.id.BoardInBtn);
        BoardInBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getActivity() , InsertBoardActivity.class);
                intent.putExtra("userID",MainActivity.userID);
                startActivity(intent);
            }
        });

        return view;
    }


    public void onCreateOptionsMenu(Menu menu, MenuInflater inflater) {
        super.onCreateOptionsMenu(menu,inflater);
        inflater.inflate(R.menu.menu,menu);
    }

    // 우리 어플은 오전 7시에 시작해서 오후 10시에 끝나는 특성상 날짜를 기제 할 필요가 없음.
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.timeSort:{
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Waiting") || dataList.get(i).getOrderID().equals(MainActivity.userID)){
                        dataList.remove(i);
                    }
                }
                for(int i=0;i<dataList.size();i++){
                    for(int j=0;j<dataList.size();j++){
                        if(Integer.parseInt(dataList.get(i).getErrandTime()) > Integer.parseInt(dataList.get(j).getErrandTime())){
                            Collections.swap(dataList,i,j);
                        }
                    }
                }
                mainAdapter.notifyDataSetChanged();
                Toast.makeText(getContext(), "시간순 클릭됨", Toast.LENGTH_LONG).show();
                return true;
            }
            case R.id.priceSort: {
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Waiting") || dataList.get(i).getOrderID().equals(MainActivity.userID)){
                        dataList.remove(i);
                    }
                }
                for(int i=0;i<dataList.size();i++){
                    for(int j=0;j<dataList.size();j++){
                        if(Integer.parseInt(dataList.get(i).getErrandPrice().replace("원","")) > Integer.parseInt(dataList.get(j).getErrandPrice().replace("원",""))){
                            Collections.swap(dataList,i,j);
                        }
                    }
                }
                mainAdapter.notifyDataSetChanged();
                Toast.makeText(getContext(), "가격순 클릭됨", Toast.LENGTH_LONG).show();
                return true;
            }
            case R.id.logout: {
                Intent intentSerivce = new Intent(getContext(), MyService.class);
                intentSerivce.setAction("/quit");
                getContext().startService(intentSerivce);

                Intent intent = new Intent(this.getActivity() , LoginActivity.class);
                startActivity(intent);
                return true;
            }
            case R.id.Notify : {
                Intent intent = new Intent(this.getActivity() , NotifyActivity.class);
                intent.putExtra("userID",MainActivity.userID);
                startActivity(intent);
                return true;
            }
            case R.id.Guide :{
                Intent intent = new Intent(this.getActivity() , GuideActivity.class);
                intent.putExtra("userID",MainActivity.userID);
                startActivity(intent);
                return true;
            }

            case R.id.CustomCare :{
                Intent intent = new Intent(this.getActivity() , CustomCareActivity.class);
                intent.putExtra("userID",MainActivity.userID);
                startActivity(intent);
                return true;
            }
            default:{
                return true;
            }
        }
    }

    @Override
    public void onResume() {
        super.onResume();
        getActivity().invalidateOptionsMenu();
    }

    public void getBoard(){
        //boardsArray 및 JsonList 초기화
        boardsArray.clear();
        for(int i =0;i<JsonList.length;i++){
            JsonList[i] = null;
        }

        //서버에서 데이터 받아오는곳
        ContentValues values = new ContentValues();
        String response = "";
        NetworkTask networkTask = new NetworkTask(resulturl("LoadBoardServlet"), values);
        try {
            response = networkTask.execute().get();
            Log.d("",response);
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        //데이터 세분화 및 추가
        try{
            response=response.substring(1,response.length()-1);
            JsonList = response.split("\\},", 50);
            for(int i =0;i<JsonList.length-1;i++){
                JsonList[i] += "}";
                Log.d("결과값? : ",JsonList[i]);
            }

            for(int i =0;i<JsonList.length;i++){
                boards = new Board_Module();
                JSONObject jsonObject = new JSONObject(JsonList[i]);
                boards.setO_number(jsonObject.getInt("o_number"));
                boards.setOrders(jsonObject.getString("orders"));
                boards.setTitle(jsonObject.getString("title"));
                boards.setText(jsonObject.getString("text"));
                boards.setLatitude(jsonObject.getDouble("latitude"));
                boards.setLongitude(jsonObject.getDouble("longitude"));
                boards.setDetail_address(jsonObject.getString("detail_address"));
                boards.setPrice(jsonObject.getInt("price"));
                boards.setO_time(jsonObject.getString("o_time").substring(8));
                boards.setProgress(jsonObject.getString("progress"));
                if(jsonObject.getString("progress").equals("@@Waiting")){
                    boards.setErrand("");
                }
                else {
                    boards.setErrand(jsonObject.getString("errand"));
                }
                boardsArray.add(boards);
            }

            for(int i=0; i<boardsArray.size();i++){
                MainData mainData = new MainData(R.drawable.human,boardsArray.get(i).getOrders(),boardsArray.get(i).getErrand(),boardsArray.get(i).getO_time(),boardsArray.get(i).getText(),String.valueOf(boardsArray.get(i).getPrice()),boardsArray.get(i).getProgress(),boardsArray.get(i).getTitle(),boardsArray.get(i).getO_number());
                dataList.add(mainData);
            }

        }
        catch (JSONException e){
            e.printStackTrace();
        }
    }

    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }

    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
 ```
 
 -MenuList_Fragment(메뉴리스트)
 
 ```java
 public class MenuList_Fragment extends Fragment {

    public View view;
    public Toolbar mainToolbar;
    public ArrayList<Board_Module> boardsArray = new ArrayList<Board_Module>();

    public Board_Module boards;
    public String[] JsonList = new String[50];
    //public Button Completed_btn;

    private ArrayList<MainData> dataList;
    private MainAdapter mainAdapter;
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.menulist_fragment, container, false);
        setHasOptionsMenu(true);

        mainToolbar = view.findViewById(R.id.mainToolbar);
        mainToolbar.setTitle(R.string.mainToolbar);
        ((AppCompatActivity) getActivity()).setSupportActionBar(mainToolbar);

        recyclerView = view.findViewById(R.id.rv_menulist);
        linearLayoutManager = new LinearLayoutManager(view.getContext());
        recyclerView.setLayoutManager(linearLayoutManager);

        dataList = new ArrayList<>();
        mainAdapter = new MainAdapter(dataList);
        recyclerView.setAdapter(mainAdapter);
        getBoard();
        for(int i=dataList.size()-1;i>=0;i--){
            if(!dataList.get(i).getErrandProgress().equals("@@Completed") || !dataList.get(i).getOrderID().equals(MainActivity.userID)){
                dataList.remove(i);
            }
        }
        mainAdapter.notifyDataSetChanged();

        return view;
    }

    public void onCreateOptionsMenu(Menu menu, MenuInflater inflater) {
        super.onCreateOptionsMenu(menu, inflater);
        inflater.inflate(R.menu.menulist_menu, menu);
    }

    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.waiting: {
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Waiting")||!dataList.get(i).getOrderID().equals(MainActivity.userID)){
                        dataList.remove(i);
                    }
                }
                mainAdapter.notifyDataSetChanged();
                Toast.makeText(getContext(), "대기중인 주문", Toast.LENGTH_LONG).show();
                return true;
            }
            case R.id.ongoing: {
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Ongoing") || !dataList.get(i).getOrderID().equals(MainActivity.userID)){
                        dataList.remove(i);
                    }
                }
                mainAdapter.notifyDataSetChanged();
                Toast.makeText(getContext(), "진행중인 주문", Toast.LENGTH_LONG).show();
                return true;
            }
            case R.id.accept: {
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Ongoing") || !dataList.get(i).getErrandID().equals(MainActivity.userID)){
                        dataList.remove(i);// 상태 - 온고잉 남는유저는 자기빼고 다남아
                    }
                }
                mainAdapter.notifyDataSetChanged();
                Toast.makeText(getContext(), "수락한 주문", Toast.LENGTH_LONG).show();
                return true;
            }
            case R.id.completed: {
                dataList.clear();
                getBoard();
                for(int i=dataList.size()-1;i>=0;i--){
                    if(!dataList.get(i).getErrandProgress().equals("@@Completed") || !(dataList.get(i).getOrderID().equals(MainActivity.userID) || dataList.get(i).getErrandID().equals(MainActivity.userID))){
                        dataList.remove(i);
                    }
                }
                mainAdapter.notifyDataSetChanged();
                Toast.makeText(getContext(), "완료된 주문", Toast.LENGTH_LONG).show();
                return true;
            }
            case R.id.logout: {
                Intent intent = new Intent(this.getActivity(), LoginActivity.class);
                startActivity(intent);
                return true;
            }
            default: {
                return true;
            }
        }
    }


    @Override
    public void onResume() {
        super.onResume();
        getActivity().invalidateOptionsMenu();
    }



    public void getBoard(){
        //boardsArray 및 JsonList 초기화
        boardsArray.clear();
        for(int i =0;i<JsonList.length;i++){
            JsonList[i] = null;
        }

        boardsArray.clear();
        for(int i =0;i<JsonList.length;i++){
            JsonList[i] = null;
        }

        //서버에서 데이터 받아오는곳
        ContentValues values = new ContentValues();
        String response = "";
        NetworkTask networkTask = new NetworkTask(resulturl("LoadBoardServlet"), values);
        try {
            response = networkTask.execute().get();
            Log.d("",response);
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        //데이터 세분화 및 추가
        try{
            response=response.substring(1,response.length()-1);

            JsonList = response.split("\\},", 50);
            for(int i =0;i<JsonList.length-1;i++){
                JsonList[i] += "}";
                Log.d("결과값? : ",JsonList[i]);
            }

            for(int i =0;i<JsonList.length;i++){
                boards = new Board_Module();
                JSONObject jsonObject = new JSONObject(JsonList[i]);
                boards.setO_number(jsonObject.getInt("o_number"));
                boards.setOrders(jsonObject.getString("orders"));
                boards.setTitle(jsonObject.getString("title"));
                boards.setText(jsonObject.getString("text"));
                boards.setLatitude(jsonObject.getDouble("latitude"));
                boards.setLongitude(jsonObject.getDouble("longitude"));
                boards.setDetail_address(jsonObject.getString("detail_address"));
                boards.setPrice(jsonObject.getInt("price"));
                boards.setO_time(jsonObject.getString("o_time").substring(8));
                boards.setProgress(jsonObject.getString("progress"));
                if(jsonObject.getString("progress").equals("@@Waiting")){
                    boards.setErrand("");
                }
                else {
                    boards.setErrand(jsonObject.getString("errand"));
                }
                boardsArray.add(boards);
            }

            for(int i=0; i<boardsArray.size();i++){
                MainData mainData = new MainData(R.drawable.human,boardsArray.get(i).getOrders(),boardsArray.get(i).getErrand(),boardsArray.get(i).getO_time(),boardsArray.get(i).getText(),String.valueOf(boardsArray.get(i).getPrice()),boardsArray.get(i).getProgress(),boardsArray.get(i).getTitle(),boardsArray.get(i).getO_number());
                dataList.add(mainData);
            }
        }
        catch (JSONException e){
            e.printStackTrace();
        }
    }

    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }

    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
 ```
 -Chatting_Fragment(채팅)
```java
public class Chatting_Fragment extends Fragment implements View.OnClickListener, View.OnTouchListener{

    public SimpleDateFormat format = new SimpleDateFormat("yyyyMMddHHmmss");
    public ChattingRecordModule chatRecordModule;

    public String time="";
    public String hour="";
    public String minute="";
    public String second="";

    public String userID;
    public String otherID;
    public String orderID;
    public String errandID;
    public int num;

    public Toolbar chatToolbar;
    public Button btn_send;
    public EditText et_chat;

    public float oldXvalue, tmp_x;
    public float oldYvalue, tmp_y;

    public View view;
    public ImageView btn_nav;
    public ArrayList<ChattingRecordModule> chatArray = new ArrayList<ChattingRecordModule>();
    public Chat_Module chat;
    public String[] JsonList = new String[50];;

    private ArrayList<ChattingContentData> dataList;
    private ChattingAdapter chattingAdapter;
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager;

    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        ContentValues values = new ContentValues();
        String response = "";
        values.put("InputIDForChat",MainActivity.userID);
        NetworkTask networkTask = new NetworkTask(resulturl("OrdererErranderID"), values);
        try {
            response = networkTask.execute().get();
            Log.d("ㅡㅡ", response);
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        if(response.contains("orderID")){
            userID = MainActivity.userID;
            try {
                JSONObject jsonObject = new JSONObject(response);
                num = jsonObject.getInt("increase_num");
                orderID = jsonObject.getString("orderID");
                errandID = jsonObject.getString("errandID");
                Log.d("orderID",orderID);
                Log.d("errandID",errandID);
            } catch (JSONException e) {
                e.printStackTrace();
            }

            view = inflater.inflate(R.layout.chatting_fragment, container, false);
            setHasOptionsMenu(true);

            chatToolbar = view.findViewById(R.id.cttoolbar);
            if (userID.equals(orderID)) {
                chatToolbar.setTitle(errandID + " Chatting");
            } else {
                chatToolbar.setTitle(orderID + " Chatting");
            }
            ((AppCompatActivity) getActivity()).setSupportActionBar(chatToolbar);

            btn_nav = view.findViewById(R.id.btn_nav);
            btn_nav.setOnClickListener(this);
            //btn_nav.setOnTouchListener((View.OnTouchListener) this);

            btn_send = view.findViewById(R.id.btn_send);
            et_chat = view.findViewById(R.id.Et_chat);

            recyclerView = view.findViewById(R.id.chat_rv);
            linearLayoutManager = new LinearLayoutManager(view.getContext());
            recyclerView.setLayoutManager(linearLayoutManager);

            dataList = new ArrayList<>();
            chattingAdapter = new ChattingAdapter(dataList);
            recyclerView.setAdapter(chattingAdapter);

            if(userID.equals(errandID)){
                otherID = orderID;
                Log.d("data","주인장");
            }
            else {
                otherID = errandID;
                Log.d("data","손놈");
            }

            getChattingRecord();
            chattingAdapter.notifyDataSetChanged();

            btn_send.setOnClickListener(this);
        }
        else{
            view = inflater.inflate(R.layout.notchatting, container, false);
            setHasOptionsMenu(true);
        }


        return view;
    }

    @Override
    public boolean onTouch(View v, MotionEvent event) {
        int parentWidth = ((ViewGroup) v.getParent()).getWidth();    // 부모 View 의 Width
        int parentHeight = ((ViewGroup) v.getParent()).getHeight();    // 부모 View 의 Height

        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN: {
                oldXvalue = event.getX();
                oldYvalue = event.getY();
                tmp_x = event.getX();
                tmp_y = event.getY();
            }
            case MotionEvent.ACTION_MOVE: {
                v.setX(v.getX() + (event.getX()) - (v.getWidth() / 2));
                v.setY(v.getY() + (event.getY()) - (v.getHeight() / 2));
            }
            case MotionEvent.ACTION_UP: {
                if (tmp_x == event.getX() || tmp_y == event.getY()) {
                    return false;
                } else {
                    if (v.getX() < 0) {
                        v.setX(0);
                    } else if ((v.getX() + v.getWidth()) > parentWidth) {
                        v.setX(parentWidth - v.getWidth());
                    }

                    if (v.getY() < 0) {
                        v.setY(0);
                    } else if ((v.getY() + v.getHeight()) > parentHeight) {
                        v.setY(parentHeight - v.getHeight());
                    }
                    return true;
                }
            }
        }
        return false;
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()){
            case R.id.btn_send : {
                Intent intent = new Intent(getContext(), MyService.class);
                intent.setAction("Send@" + userID + "@" + otherID + "@" + et_chat.getText().toString());
                getContext().startService(intent);
                break;
            }
            case R.id.btn_nav: {
                Intent intent = new Intent(getContext(), AddressActivity.class);
                intent.putExtra("errandID",errandID);
                startActivity(intent);
                break;
            }
        }
        et_chat.setText("");
    }

    private BroadcastReceiver mMessageReceiver = new BroadcastReceiver() {
        @Override
        public void onReceive(Context context, Intent intent) {
            String msg = intent.getStringExtra("message");
            liveGetMsg(msg);
            chattingAdapter.notifyDataSetChanged();
        }
    };

    public void liveGetMsg(String msg){
        String[] msgDiv = msg.split("@");
        String time = String.valueOf(format.format(System.currentTimeMillis()));
        String currentTime = time.substring(8);
        String hour = time.substring(0,2);
        String minute = time.substring(2,4);
        String second = time.substring(4,6);
        ChattingContentData chatData = new ChattingContentData(R.drawable.human, 1, msgDiv[0], msgDiv[1],hour + ":" + minute + ":" + second);
        dataList.add(chatData);
    }

    @Override
    public void onResume() {
        super.onResume();
        LocalBroadcastManager.getInstance(getContext()).registerReceiver(mMessageReceiver, new IntentFilter("custom-event-name"));
    }

    @Override
    public void onPause() {
        super.onPause();
        LocalBroadcastManager.getInstance(getContext()).unregisterReceiver(mMessageReceiver);
    }


    public void getChattingRecord() {
        //boardsArray 및 JsonList 초기화
        chatArray.clear();
        for (int i = 0; i < JsonList.length; i++) {
            JsonList[i] = null;
        }
        //서버에서 데이터 받아오는곳
        ContentValues values = new ContentValues();
        values.put("userID",userID);
        values.put("otherID",otherID);
        String response = "";
        NetworkTask networkTask = new NetworkTask(resulturl("CallChattingRoomDataServlet"), values);
        try {
            response = networkTask.execute().get();
            Log.d("",response);
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        if(response.contains("senderID")){
            //데이터 세분화 및 추가
            try {
                response = response.substring(1, response.length() - 1);
                JsonList = response.split("\\},", 50);
                for (int i = 0; i < JsonList.length - 1; i++) {
                    JsonList[i] += "}";
                    Log.d("결과값? : ", JsonList[i]);
                }

                for (int i = 0; i < JsonList.length; i++) {
                    chatRecordModule = new ChattingRecordModule();
                    JSONObject jsonObject = new JSONObject(JsonList[i]);
                    chatRecordModule.setNum(jsonObject.getInt("num"));
                    chatRecordModule.setSenderID(jsonObject.getString("senderID"));
                    time = jsonObject.getString("c_time").substring(8);
                    hour = time.substring(0,2);
                    minute = time.substring(2,4);
                    second = time.substring(4,6);
                    chatRecordModule.setC_time(hour + ":" + minute + ":" + second);
                    chatRecordModule.setMsg(jsonObject.getString("Msg"));
                    chatArray.add(chatRecordModule);
                }

                for (int i = 0; i < chatArray.size(); i++) {
                    ChattingContentData chatData = new ChattingContentData(R.drawable.human, chatArray.get(i).getNum(), chatArray.get(i).getSenderID(), chatArray.get(i).getMsg(),chatArray.get(i).getC_time());
                    dataList.add(chatData);
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
    }

    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }

    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
```

 - Myinfo_Fragment(내정보수정)

```java
public class MyInfo_Fragment extends Fragment implements View.OnClickListener {

    public Toolbar modifytoolbar;

    EditText ModifyPWText;
    EditText ModifyPWConfirmText;
    TextView ModifyIDText,ModifyNameText,ModifyMajorText,ModifyS_NumText,ModifyGenderText;
    String userID;
    Button ModifyButton;
    public View view;
    public MyInfo_Fragment(){

    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.myinfo_fragment, container, false);

        modifytoolbar = view.findViewById(R.id.ModifyToolbar);
        modifytoolbar.setTitle(R.string.defaultToolbar);
        ((AppCompatActivity)getActivity()).setSupportActionBar(modifytoolbar);

        ModifyPWText = view.findViewById(R.id.ModifyPWText);
        ModifyPWConfirmText = view.findViewById(R.id.ModifyPWConfirmText);
        ModifyButton = view.findViewById(R.id.ModifyButton);

        ModifyIDText = view.findViewById(R.id.ModifyIDText);
        ModifyNameText = view.findViewById(R.id.ModifyNameText);
        ModifyMajorText = view.findViewById(R.id.ModifyMajorText);
        ModifyS_NumText = view.findViewById(R.id.ModifyS_NumText);
        ModifyGenderText = view.findViewById(R.id.ModifyGenderText);
        ModifyButton.setOnClickListener(this);


        ContentValues values = new ContentValues();
        values.put("AccessInfoByID", MainActivity.userID);

        String response = "";
        NetworkTask networkTask = new NetworkTask(resulturl("ShowUserInfoServlet"), values);

        try {
            response = networkTask.execute().get();
            JSONObject jsonObject = new JSONObject(response);

            ModifyIDText.setText(jsonObject.getString("userId"));
            ModifyNameText.setText(jsonObject.getString("userName"));
            ModifyS_NumText.setText(jsonObject.getString("userSchoolNumber"));
            ModifyGenderText.setText(jsonObject.getString("userGender"));
            ModifyMajorText.setText(jsonObject.getString("userMajor"));

        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return view;
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()){
            case R.id.ModifyButton : {
                if(!ModifyPWText.getText().toString().equals(ModifyPWConfirmText.getText().toString()) || ModifyPWText.getText().equals("")) {
                    ModifyPWText.setText("");
                    ModifyPWConfirmText.setText("");
                    Toast.makeText(getContext(),"비밀번호가 없거나 같지않습니다.",Toast.LENGTH_SHORT).show();
                }
                else{
                    if(ModifyPWText.getText().toString().equals("")){
                        Toast.makeText(getContext(),"비밀번호를 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        ModifyPWText.requestFocus();
                    }
                    else if(ModifyPWConfirmText.getText().toString().equals("")){
                        Toast.makeText(getContext(),"비밀번호확인을 입력해주세요.",Toast.LENGTH_SHORT).show();;
                        ModifyPWConfirmText.requestFocus();
                    }
                    else{
                        ContentValues values = new ContentValues();
                        values.put("IdentificationID", MainActivity.userID);
                        values.put("AfterPass", SignatureUtil.applySHA256(ModifyPWText.getText().toString()));
                        NetworkTask networkTask = new NetworkTask(resulturl("ChangePWServlet"), values);
                        networkTask.execute();
                        Intent intentSerivce = new Intent(getContext(), MyService.class);
                        intentSerivce.setAction("/quit");
                        getContext().startService(intentSerivce);
                        Intent intent = new Intent(this.getActivity() , LoginActivity.class);
                        startActivity(intent);
                        Toast.makeText(getContext(),"변경된 비밀번호로 다시 로그인 해주세요",Toast.LENGTH_SHORT).show();
                    }
                }
            }
            default:{
                break;
            }

        }
    }
    public String resulturl(String url) { //ip 값 바꿔주는 부분 이거있어야 서버 쌉가능
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }
    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
```

- GuideActivity(가이드라인)
```public class GuideActivity extends AppCompatActivity {
    public static String userID;
    FragmentPagerAdapter adapterViewPager;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_guide);

        userID = getIntent().getStringExtra("userID");

        ViewPager vpPager = (ViewPager) findViewById(R.id.vpPager);
        adapterViewPager = new MyPagerAdapter(getSupportFragmentManager());
        vpPager.setAdapter(adapterViewPager);

        CircleIndicator indicator = (CircleIndicator) findViewById(R.id.indicator);
        indicator.setViewPager(vpPager);

    }

    public static class MyPagerAdapter extends FragmentPagerAdapter {
        private static int NUM_ITEMS = 5;

        public MyPagerAdapter(FragmentManager fragmentManager) {
            super(fragmentManager);
        }

        // Returns total number of pages
        @Override
        public int getCount() {
            return NUM_ITEMS;
        }

        // Returns the fragment to display for that page
        @Override
        public Fragment getItem(int position) {
            switch (position) {
                case 0:
                    return Guide_First.newInstance(0, "Page # 1");
                case 1:
                    return Guide_second.newInstance(1, "Page # 2");
                case 2:
                    return Guide_third.newInstance(2, "Page # 3");
                case 3:
                    return Guide_Fourth.newInstance(3, "Page # 4");
                case 4:
                    return Guide_Five.newInstance(4, "Page # 5");
                default:
                    return null;
            }
        }

        @Override
        public CharSequence getPageTitle(int position) {
            return "Page " + position;
        }

    }
}
```

- NoticeActivity(공지사항)

```java
public class NotifyActivity extends AppCompatActivity {

    public Notify_Module notify;
    public ArrayList<Notify_Module> notiArray = new ArrayList<>();
    public String[] JsonList = new String[50];;
    public String userID = "";
    public ArrayList<NoticeData> dataList;
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager;
    private NoticeAdapter noticeAdapter;
    private Toolbar notiToolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_notify);

        notiToolbar = findViewById(R.id.notiToolbar);
        notiToolbar.setTitle(R.string.mainToolbar);
        setSupportActionBar(notiToolbar);

        userID = getIntent().getStringExtra("userID");
        dataList = new ArrayList<NoticeData>();

        recyclerView = findViewById(R.id.noti_rv);
        linearLayoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(linearLayoutManager);

        noticeAdapter = new NoticeAdapter(dataList);
        recyclerView.setAdapter(noticeAdapter);
        getBoard();
        noticeAdapter.notifyDataSetChanged();
    }

    public void getBoard(){
        //boardsArray 및 JsonList 초기화
        notiArray.clear();
        for(int i =0;i<JsonList.length;i++){
            JsonList[i] = null;
        }

        //서버에서 데이터 받아오는곳
        ContentValues values = new ContentValues();
        String response = "";
        NetworkTask networkTask = new NetworkTask(resulturl("NotifySenderServlet"), values);
        try {
            response = networkTask.execute().get();
            Log.d("",response);
        } catch (ExecutionException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        //데이터 세분화 및 추가
        try{
            response=response.substring(1,response.length()-1);
            JsonList = response.split("\\},", 50);
            for(int i =0;i<JsonList.length-1;i++){
                JsonList[i] += "}";
            }

            for(int i =0;i<JsonList.length;i++){
                notify = new Notify_Module();
                JSONObject jsonObject = new JSONObject(JsonList[i]);
                notify.setNum(jsonObject.getString("num"));
                notify.setTitle(jsonObject.getString("title"));
                notify.setContent(jsonObject.getString("content"));
                notify.setTime(jsonObject.getString("time"));
                notiArray.add(notify);
            }
            for(Notify_Module noti : notiArray){
                Log.d("f",noti.getNum()+noti.getTitle()+noti.getContent()+noti.getTime());
                NoticeData noticeData = new NoticeData(noti.getNum(),noti.getTitle(),noti.getContent(),noti.getTime());
                dataList.add(noticeData);
            }
        }
        catch (JSONException e){
            e.printStackTrace();
        }
    }

    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.noticemenu,menu);
        return true;
    }

    // 우리 어플은 오전 7시에 시작해서 오후 10시에 끝나는 특성상 날짜를 기제 할 필요가 없음.
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.refresh : {
                dataList.clear();
                getBoard();
                noticeAdapter.notifyDataSetChanged();
                return true;
            }
            default:{
                return true;
            }
        }
    }

    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }

    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}
```

- InsertBoardActivity(게시글 등록)

```java
public class InsertBoardActivity extends AppCompatActivity {

    private GpsTracker gpsTracker;
    private static final int GPS_ENABLE_REQUEST_CODE = 2001;
    private static final int PERMISSIONS_REQUEST_CODE = 100;
    String[] REQUIRED_PERMISSIONS = {Manifest.permission.ACCESS_FINE_LOCATION, Manifest.permission.ACCESS_COARSE_LOCATION};

    EditText TitleText;
    EditText AddressText;
    EditText PriceText;
    EditText ContentText;

    Toolbar ConfirmToolbar;
    String userID;
    String latitude;
    String longitude;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_insert_board);

        ConfirmToolbar = findViewById(R.id.confirmToolbar);
        ConfirmToolbar.setTitle(R.string.defaultToolbar);
        setSupportActionBar(ConfirmToolbar);

        TitleText = findViewById(R.id.TitleText);
        AddressText = findViewById(R.id.AddressText);
        PriceText = findViewById(R.id.PriceText);
        ContentText = findViewById(R.id.ConTentText);

        userID =getIntent().getStringExtra("userID");

        if (checkLocationServicesStatus()) {
            checkRunTimePermission();
        } else {
            showDialogForLocationServiceSetting();
        }
    }

    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater menuInflater = getMenuInflater();
        menuInflater.inflate(R.menu.boardinsertmenu, menu);
        return true;
    }

    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.BoardConfirm: {
                if (TitleText.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), "제목을 입력해주세요.", Toast.LENGTH_SHORT).show();
                    TitleText.requestFocus();
                } else if (PriceText.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), "가격을 입력해주세요.", Toast.LENGTH_SHORT).show();
                    PriceText.requestFocus();
                } else if (ContentText.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), "내용을 입력해주세요.", Toast.LENGTH_SHORT).show();
                    ContentText.requestFocus();
                } else {
                    gpsTracker = new GpsTracker(InsertBoardActivity.this);
                    double latitude = gpsTracker.getLatitude();
                    double longitude = gpsTracker.getLongitude();

                    ContentValues values = new ContentValues();
                    values.put("Post_orders", userID);
                    values.put("Post_title", TitleText.getText().toString());
                    values.put("Post_address", AddressText.getText().toString());
                    values.put("Post_price", PriceText.getText().toString());
                    values.put("Post_text", ContentText.getText().toString());
                    values.put("Post_latitude", String.valueOf(latitude));
                    values.put("Post_longitude", String.valueOf(longitude));
                    values.put("Post_progress","@@Waiting");
                    Log.d("위도",String.valueOf(latitude));
                    Log.d("경도",String.valueOf(longitude));

                    NetworkTask networkTask = new NetworkTask(resulturl("PostOnBoardServlet"), values);
                    networkTask.execute();

                    Intent intent = new Intent(InsertBoardActivity.this, MainActivity.class);
                    intent.putExtra("userID",MainActivity.userID);
                    startActivity(intent);
                }

                //정보들을 서버에 전달하고 메인 엑티비티로 이동하는 기능
                //정보를 서버에 전달할때 gps를 이용해서 위도,경도도 같이 전달
                return true;
            }
            default: {
                return true;
            }
        }
    }

    public void onRequestPermissionsResult(int permsRequestCode,
                                           @NonNull String[] permissions,
                                           @NonNull int[] grandResults) {
        if (permsRequestCode == PERMISSIONS_REQUEST_CODE && grandResults.length == REQUIRED_PERMISSIONS.length) {

            // 요청 코드가 PERMISSIONS_REQUEST_CODE 이고, 요청한 퍼미션 개수만큼 수신되었다면

            boolean check_result = true;


            // 모든 퍼미션을 허용했는지 체크합니다.

            for (int result : grandResults) {
                if (result != PackageManager.PERMISSION_GRANTED) {
                    check_result = false;
                    break;
                }
            }


            if (check_result) {

                //위치 값을 가져올 수 있음
                ;
            } else {
                if (ActivityCompat.shouldShowRequestPermissionRationale(this, REQUIRED_PERMISSIONS[0])
                        || ActivityCompat.shouldShowRequestPermissionRationale(this, REQUIRED_PERMISSIONS[1])) {
                    Toast.makeText(InsertBoardActivity.this, "퍼미션이 거부되었습니다. 앱을 다시 실행하여 퍼미션을 허용해주세요.", Toast.LENGTH_LONG).show();
                    finish();
                } else {
                    Toast.makeText(InsertBoardActivity.this, "퍼미션이 거부되었습니다. 설정(앱 정보)에서 퍼미션을 허용해야 합니다. ", Toast.LENGTH_LONG).show();

                }
            }

        }
    }

    void checkRunTimePermission() {

        //런타임 퍼미션 처리
        // 1. 위치 퍼미션을 가지고 있는지 체크합니다.
        int hasFineLocationPermission = ContextCompat.checkSelfPermission(InsertBoardActivity.this,
                Manifest.permission.ACCESS_FINE_LOCATION);
        int hasCoarseLocationPermission = ContextCompat.checkSelfPermission(InsertBoardActivity.this,
                Manifest.permission.ACCESS_COARSE_LOCATION);


        if (hasFineLocationPermission == PackageManager.PERMISSION_GRANTED &&
                hasCoarseLocationPermission == PackageManager.PERMISSION_GRANTED) {
        } else {
            if (ActivityCompat.shouldShowRequestPermissionRationale(InsertBoardActivity.this, REQUIRED_PERMISSIONS[0])) {
                Toast.makeText(InsertBoardActivity.this, "이 앱을 실행하려면 위치 접근 권한이 필요합니다.", Toast.LENGTH_LONG).show();
                ActivityCompat.requestPermissions(InsertBoardActivity.this, REQUIRED_PERMISSIONS,
                        PERMISSIONS_REQUEST_CODE);


            } else {
                ActivityCompat.requestPermissions(InsertBoardActivity.this, REQUIRED_PERMISSIONS,
                        PERMISSIONS_REQUEST_CODE);
            }

        }

    }


    //여기부터는 GPS 활성화를 위한 메소드들
    private void showDialogForLocationServiceSetting() {

        AlertDialog.Builder builder = new AlertDialog.Builder(InsertBoardActivity.this);
        builder.setTitle("위치 서비스 비활성화");
        builder.setMessage("앱을 사용하기 위해서는 위치 서비스가 필요합니다.\n"
                + "위치 설정을 수정하실래요?");
        builder.setCancelable(true);
        builder.setPositiveButton("설정", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int id) {
                Intent callGPSSettingIntent
                        = new Intent(android.provider.Settings.ACTION_LOCATION_SOURCE_SETTINGS);
                startActivityForResult(callGPSSettingIntent, GPS_ENABLE_REQUEST_CODE);
            }
        });
        builder.setNegativeButton("취소", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int id) {
                dialog.cancel();
            }
        });
        builder.create().show();
    }


    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        switch (requestCode) {

            case GPS_ENABLE_REQUEST_CODE:

                //사용자가 GPS 활성 시켰는지 검사
                if (checkLocationServicesStatus()) {
                    if (checkLocationServicesStatus()) {

                        Log.d("@@@", "onActivityResult : GPS 활성화 되있음");
                        checkRunTimePermission();
                        return;
                    }
                }

                break;
        }
    }

    public boolean checkLocationServicesStatus() {
        LocationManager locationManager = (LocationManager) getSystemService(LOCATION_SERVICE);

        return locationManager.isProviderEnabled(LocationManager.GPS_PROVIDER)
                || locationManager.isProviderEnabled(LocationManager.NETWORK_PROVIDER);
    }

    public String resulturl(String url) { //ip 값 바꿔주는 부분
        String resultUrl = "http://"+FinalURLIP.address+"/" + url;
        return resultUrl;
    }
    public class NetworkTask extends AsyncTask<Void, Void, String> {

        String url;
        ContentValues values;

        NetworkTask(String url, ContentValues values){
            this.url = url;
            this.values = values;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            //progress bar를 보여주는 등등의 행위
        }

        @Override
        protected String doInBackground(Void... params) {
            String result;
            RequestHttpURLConnection requestHttpURLConnection = new RequestHttpURLConnection();
            result = requestHttpURLConnection.request(url, values);
            return result; // 결과가 여기에 담깁니다. 아래 onPostExecute()의 파라미터로 전달됩니다.
        }

        @Override
        protected void onPostExecute(String result) {
            // 통신이 완료되면 호출됩니다.
            // 결과에 따른 UI 수정 등은 여기서 합니다.
            //Toast.makeText(getApplicationContext(), result, Toast.LENGTH_LONG).show();
        }
    }
}

```
___
## 10. "갖다드림" 어플리케이션 한계점

- 코로나19 바이러스로 인한 비대면수업 = 학교주변 인원 감소
- 방학기간 학교주변 인원 감소에 따른 사용자 감소
- 전문업체가 아닌 사용자끼리 서비스를 제공하는 형태이므로 Service Quality 상이할 가능성有

___

## 11. 결론

- "갖다드림" 은 캠퍼스를 중심으로 학생간 심부름 서비스 플랫폼을 제공하는 어플이다.
- 고용된 직원으로 서비스를 제공하는 것이 아니라, 학생 간 서비스를 주고 받는다는 점에서 기존의 심부름 어플과 차별성을 두고 있다. 또한 같은 학교의 재학생이 서비스를 제공한다는 점에서 서비스의 신뢰도를 보장할 수 있다. 또한 배달 개념의 서비스가아닌 심부름 개념이기에 물건 배달 외에 서비스를 제공할 수 있다.
- 캠퍼스 내 학생 및 기숙사/인근 거주 학생을 중심으로 운영되므로 , 방학이나 전염병 유행 상황 시 서비스가 원활하게 운영되지 않을 수 있다. 또한 서비스에 대한 신뢰도가 사용자의 매너에 의존한다는 점에서 한계점을 가진다. 
- Android 안드로이드에서 HttpUrlConnection을 이용해 Servlet과 단방향 통신으로 하고, service 기능을 이용해 socket과 양방향 통신을 하며, 백엔드로 Servlet과 socket이 JDBC를 통해 Database에 접근 및 관리한다.
___
