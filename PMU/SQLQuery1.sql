create table Feader(
feaderID int IDENTITY(1,1) primary key NOT NULL ,
Fname nvarchar(200)  NOT NULL
);
create table buses(
busID int IDENTITY(3,1) primary key NOT NULL ,
feaderId int references feader not null
);

create table phaseA(
busID int references buses not null,
vh decimal(10,8),
vl decimal(10,8),
ih  decimal(10,8),
il decimal(10,8),
ph decimal(10,8),
qh decimal(10,8),
pl decimal(10,8),
ql decimal(10,8),
plosscable decimal(10,8),
qlosscable decimal(10,8),
plosstr decimal(10,8),
qlosstr decimal(10,8),
clk datetime 
);

create table phaseB(
busID int references buses not null,
vh decimal(10,8),
vl decimal(10,8),
ih  decimal(10,8),
il decimal(10,8),
ph decimal(10,8),
qh decimal(10,8),
pl decimal(10,8),
ql decimal(10,8),
plosscable decimal(10,8),
qlosscable decimal(10,8),
plosstr decimal(10,8),
qlosstr decimal(10,8),
clk datetime 
);


create table phaseC(
busID int references buses not null,
vh decimal(10,8),
vl decimal(10,8),
ih  decimal(10,8),
il decimal(10,8),
ph decimal(10,8),
qh decimal(10,8),
pl decimal(10,8),
ql decimal(10,8),
plosscable decimal(10,8),
qlosscable decimal(10,8),
plosstr decimal(10,8),
qlosstr decimal(10,8),
clk datetime 
);
select buses.busID from buses
where buses.feaderId=1;
alter table phaseA ADD phaseID int ;

delete from Phase1;