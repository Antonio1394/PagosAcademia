create table students(
id int identity,
first_name varchar(50),
last_name varchar(50),
phone varchar(12),
addres varchar(50),
date_of_birth date,
in_charge varchar(50),
state varchar (50) default 'arriba',
created_at datetime,
updated_at datetime,
constraint pk_id primary key(id)
)

create table laboratories(
id int identity,
title varchar(255),
description varchar(255),
computers int,
state varchar (50) default 'libre',
created_at datetime,
updated_at datetime,
constraint pk_id_laboratories primary key(id)
)

create table passwordresets(
id int identity,
email varchar(255),
token varchar(255),
created_at datetime,
updated_at datetime
constraint pk_id_passwordresets primary key(id)
)

create table programs(
id int identity,
description varchar(255),
shelf_life int,
state varchar (50) default 'ocupado',
created_at datetime,
updated_at datetime,
constraint pk_id_programs primary key(id)
)

create table typeemployees(
id int identity,
description varchar(25),
created_at datetime,
updated_at datetime
constraint pk_id_typeemployees primary key(id)
)

create table employees(
id int identity,
first_name varchar(50),
last_name varchar(50),
phone varchar(12),
addres varchar(50),
id_type_employee int,
working_day varchar(50),
state varchar (50) default 'activo',
created_at datetime,
updated_at datetime
constraint pk_id_employees primary key(id)
constraint fk_id_type_employee foreign key(id_type_employee) references typeemployees(id)
)


create table schedules_practice(
id int identity,
time varchar(255),
type varchar(50),
state varchar(50) default 'libre',
created_at datetime,
updated_at datetime
constraint pk_id_schedules_practice primary key(id)
)


create table users(
id int identity,
username varchar(255),
password varchar(60),
type varchar(50),
id_employee int,
state varchar(50) default 'activo',
created_at datetime,
updated_at datetime
constraint pk_id_users primary key(id)
constraint fk_idemployee foreign key(id_employee) references employees(id)
)


create table payment_types(
id int identity,
description varchar(255),
amount int,
state varchar(50) default 'aceptado',
created_at datetime,
updated_at datetime
constraint pk_id_payment_types primary key(id)
)

create table groups(
id int identity,
id_program int,
id_laboratorie int,
id_employee int,
time_practice int,
day varchar(255),
schedule varchar(255),
state varchar(50) default 'activo',
created_at datetime,
updated_at datetime
constraint pk_id_groups primary key(id),
constraint fk_id_program foreign key(id_program) references  programs(id),
constraint fk_id_laboratories foreign key(id_laboratorie) references laboratories(id),
constraint fk_id_employee foreign key(id_employee) references employees(id),
constraint fk_id_time_practice foreign key(time_practice) references schedules_practice(id),

)


create table payments(
id int identity,
id_user int,
description text,
amount int,
no_document varchar(25),
state varchar(50),
type int,
created_at datetime,
updated_at datetime,
constraint pk_id_payments primary key(id),
constraint fk_id_user_payments foreign key(id_user) references users(id),
constraint fk_type foreign key(type) references payment_types(id)
)


create table inscripcions(
id int identity,
id_student int,
id_user int,
id_employee int,
id_payment int,
id_group int,
type varchar(25),
state varchar(25),
created_at datetime,
updated_at datetime,
constraint pk_id_inscripcions primary key(id),
constraint fk_id_student foreign key(id_student) references students(id),
constraint fk_id_user foreign key(id_user) references users(id),
constraint fk_id_payment foreign key(id_payment) references payments(id),
constraint fk_id_group foreign key(id_group) references groups(id),
constraint fk_id_employees foreign key(id_employee) references employees(id)
)

create table detailgroups(
id int identity,
id_group int,
id_student int,
state varchar(50),
created_at datetime,
updated_at datetime,
constraint pk_id_detail_group primary key(id),
constraint fk_id_group_detail foreign key (id_group) references groups (id),
constraint fk_id_students foreign key(id_student) references students (id)
)

create table shares(
id int identity,
id_inscripcion int,
id_payment int,
date_share date,
amount  int,
balance int,
mora int,
created_at datetime,
updated_at datetime,
constraint pk_id_shares primary key(id),
constraint fk_id_inscripcion foreign key(id_inscripcion) references inscripcions(id),
constraint fk_id_payment_shares foreign key(id_payment) references payments(id)
)

create table extra_payments(
id int identity,
id_student int,
id_payment int,
id_type_payment int,
amount int,
balance int,
created_at datetime,
updated_at datetime,
constraint pk_id_extra_paments primary key(id),
constraint fk_id_students_extra foreign key(id_student) references students(id),
constraint fk_id_payment_extra foreign key (id_payment) references payments(id),
constraint fk_id_type_payment_extra foreign key(id_type_payment) references payment_types(id)
)

create table tics(
id int identity,
id_student int,
degree varchar(50),
personal_codes varchar(20),
establishment varchar(200),
property_address varchar(200),
director_name varchar(50),
constraint pk_id_tics primary key(id),
constraint fk_id_student_tics foreign key(id_student) references students(id)
)




