use cagbil
go

alter procedure dbo.f_ekle
@musteri varchar(50), @telefon varchar(50), @faaliyet varchar(150), @tarih datetime, @durum nchar(10)

as
declare @no int

set nocount on
begin transaction

set @no=0

select @no =  max([�� No]) from faaliyet



if count(@no) = 0 begin
set @no=0

end

select @no


set @no = @no + 1

insert into faaliyet ([�� No],[M��teri Ad Soyad],[Telefon No],[Faaliyet Bilgisi],[Tarih Saat],Durum) values
(@no,@musteri,@telefon,@faaliyet,@tarih,@durum)



commit transaction
