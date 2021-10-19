--create proc createNewTempTableByName @tableName nvarchar(30)
--as
--declare @tname quotename
--set @tname = @tableName+'tmp'
--select 
--create table @tname
--select top 0 * into   from @tableName
--go
--exec sp_rename 'tmp', @tname
--USE ImportFromExcel;

--config
sp_configure 'show advanced options', 1;  
RECONFIGURE;
GO 
sp_configure 'Ad Hoc Distributed Queries', 1;  
RECONFIGURE;  
GO  

create proc loadBallotsFromExcel
as
begin
SELECT * INTO Data_dq
FROM OPENROWSET('Microsoft.Jet.OLEDB.4.0',
    'Excel 12.0; Database=C:\Users\ruti\Documents\votesProject\kalpies_report_tofes_b_18.3.21.xlsx', [Sheet1$]);
end
exec loadBallotsFromExcel
