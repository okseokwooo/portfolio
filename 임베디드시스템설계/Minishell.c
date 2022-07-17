#include <unistd.h>
#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <dirent.h>
#include <errno.h>
#include <time.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <unistd.h>
#include <malloc.h>
#include <string.h>
#include <sys/sysmacros.h>

struct Alias_name{
	char fake_name[100];
	char real_name[100];
};

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

char* getcwd(char* buf,size_t size);

void pwd(void){
	char buf[100];
	getcwd(buf,100);
	printf("%s \n",buf);
}

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

void rm(){
	char name[30];
	scanf("%s",&name);

	int nResult = remove(name);
	if(nResult == -1){
		printf("fail\n");
	}
}

char *strdups(char *s){
	char *p;
	p = (char *)malloc(strlen(s)+1);
	if(p!=NULL)
		strcpy(p,s);
	return p;
}
void ln(){	
	char a[30];
	char b[30];
	printf("put: ");
	scanf("%s %s",a,b);
	link(a,b);
}

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
int main(){
	struct Alias_name name[100];
	char a[100];
	char *words[100];
	int n = 0;
	int cat_num;
	char buffer[100];
	char his[100];
	char ali[100];
	int num;
	int number;
	int k = 0;

	while(1){
		scanf("%s",buffer);

		words[n] = strdups(buffer);
		n++;

		if(strcmp(buffer,"history")==0){
			for(int i = 0 ; i<n; i++)
				printf("[%d] %s\n",i+1,words[i]);
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

			else if(strcmp(buffer,"history")==0){
				for(int i = 0; i<n; i++)
					printf("[%d] %s\n",i+1,words[i]);
			}

			else if(strcmp(buffer,"pwd")==0){
				pwd();
			}	

			else if(strcmp(buffer,"cd")==0){
				char c[100];
				scanf("%s",c);
				getchar();
				cd(c);
			}

			else if(strcmp(buffer,"ls")==0){
				ls();
			}

			else if(strcmp(buffer,"mkdir")==0){
				mk();
			}

			else if(strcmp(buffer,"cp")==0){
				char *d[100];
				char *dd[100];
				scanf("%s%s",d,dd);
				cp(d,dd);
			}

			else if(strcmp(buffer,"exit")==0){
				break;
			}

			else if(strcmp(buffer,"stat")==0){
				st();
			}

			else if(strcmp(buffer,"rm")==0){
				rm();
			}

			else if(strcmp(buffer,"ln")==0){
				ln();
			}

			else if(strcmp(buffer,"chmod")==0){
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
			}

			else if(strcmp(buffer,"ps")==0){
				ps();
			}

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
	
			}
		}	
			

		else if(strcmp(buffer,"cat")==0){
			char s1[100];
			getchar();
			scanf("%[^\n]s",s1);
			cat(s1);
			}

		else if(strcmp(buffer,"pwd")==0){
			pwd();
		}

		else if(strcmp(buffer,"cd")==0){
			char c[100];
			scanf("%s",c);
			getchar();
			cd(c);
		}

		else if(strcmp(buffer,"ls")==0){
			ls();
		}

		else if(strcmp(buffer,"mkdir")==0){
			mk();
		}

		else if(strcmp(buffer,"cp")==0){
			char *d[100];
			char *dd[100];
			scanf("%s%s",d,dd);
			cp(d,dd);
		}

		else if(strcmp(buffer,"exit")==0){
			break;
		}

		else if(strcmp(buffer,"stat")==0){
			st();
		}

		else if(strcmp(buffer,"rm")==0){
			rm();
		}

		else if(strcmp(buffer,"ln")==0){
			ln();
		}

		else if(strcmp(buffer,"chmod")==0){
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
		}
		else if(strcmp(buffer,"ps")==0){
			ps();
		}
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

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"pwd")==0){
			pwd();
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"cd")==0){
			char c[100];
			scanf("%s",c);
			getchar();
			cd(c);
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"ls")==0){
			ls();
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"mkdir")==0){
			mk();
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"cp")==0){
			char *d[100];
			char *dd[100];
			scanf("%s%s",d,dd);
			cp(d,dd);
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"exit")==0){
			break;
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"stat")==0){
			st();
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"rm")==0){
			rm();
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"ln")==0){
			ln();
		}

		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"chmod")==0){
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
		}
		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"ps")==0){
			ps();
		}
		else if(strcmp(buffer,name[i].fake_name)==0 && strcmp(name[i].real_name,"alias")==0){
			scanf("%s",ali);
			sscanf(ali,"%[^=]=%s",name[k].fake_name,a);
			char *ac = strtok(a,"\'");
			while(ac!=NULL){
				strcpy(name[k].real_name,ac);
				ac=strtok(NULL,"\'");
			}
			k++;
		}
		}
	
	
	}
}
