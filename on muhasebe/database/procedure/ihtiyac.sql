USE [cagbil]
GO
/****** Object:  StoredProcedure [dbo].[miktarla]    Script Date: 06/15/2013 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[ihtiyac_p]
@barkod varchar(50)

as

set nocount on

begin transaction

declare @no int
declare @urunadi varchar(50)
declare @islevi varchar(50)
declare @grubu varchar(50)

begin

select @urunadi = [Ürün Adý] from ürünler where [Barkod No]=@barkod
select @islevi = Ýþlevi from ürünler where [Barkod No]=@barkod
select @grubu = Grubu from ürünler where [Barkod No]=@barkod

select @no = MAX([Barkod No]) from ihtiyac
if COUNT(@no)=0 begin
 set @no=0
end

set @no = @no + 1


insert into ihtiyac (No,[Barkod No],[Ürün Adý],Ýþlevi,Grubu) values (@no,@barkod,@urunadi,@islevi,@grubu)

end
commit transaction