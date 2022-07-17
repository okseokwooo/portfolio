 create table user_stock (
  num int not null auto_increment,
  id  char(15) not null,
  pass char(20) not null,
  name char(10) not null,
  money int not null,
  buy_stock_num int,
  buy_stock_name char(30),
  primary key(num)
  );