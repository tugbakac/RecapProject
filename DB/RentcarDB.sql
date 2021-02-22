create database Rentcar
on primary
(
	NAME=N'Rentcar_Data',
	FILENAME=N'C:\Users\tugba.kac\Documents\Database\Rentcar_Data.mdf',
	SIZE=21632KB,
	MAXSIZE=UNLIMITED,
	FILEGROWTH=16384KB
)
LOG ON 
(
	NAME=N'Rentcar_Log',
	FILENAME=N'C:\Users\tugba.kac\Documents\Database\Rentcar_Log.ldf',
	SIZE=2048KB,
	MAXSIZE=2048GB,
	FILEGROWTH=16384KB
)
GO

create table Car(CarId int, BrandId int, ColorId int, ModelYear datetime, DailyPrice decimal, CarDescription nvarchar(200)  )
create table Brand(BrandId int, BrandName nvarchar(60)  )
create table Color(ColorId int, ColorName nvarchar(60)  )
