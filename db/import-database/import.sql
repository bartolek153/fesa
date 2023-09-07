------------------------------------------------------------------
-- Como importar e exportar arquivos CSV no SQL Server
------------------------------------------------------------------
------------------------------------------
-- Requisitos
------------------------------------------
-- Banco de testes
use master
if db_id('curso') is not null
    drop database curso
go
create database curso
go
use curso
go
 
-- Tabela para testes 
create table amigos (
    id smallint, 
    nm varchar(300),
    telefone varchar(20)
)
 
-- Carga de teste
insert into amigos values
    (1, 'Antonio Manso Pacífico', '(11) 9.9999-1111'),
    (2, 'Afília Demaria De Nazaré', '(11) 9.9999-2222'),
    (3, 'Elvis Presley Da Silva', '(11) 9.9999-3333'),
    (4, 'Faraó do Egito Sousa', '(12) 9.9999-4444'),
    (5, 'Finada da Cruz', '(12) 9.9999-5555'),
    (6, 'Jean Claude Van Dame Da Silva', '(12) 9.9999-6666'),
    (7, 'José Catarrinho', '(51) 9.9999-7777'),
    (8, 'Maiquel Edy Marfy', '(51) 9.9999-8888'),
    (9, 'Salvador Das Dores', '(51) 9.9999-9999')
 
 
------------------------------------------
-- 3 formas de exportar para CSV
------------------------------------------
-- Save as "CSV"
select * from amigos
 
 
-- Requisitos: 
-- "Ativar SQLCMD Mode em Query -> SQLCMD mode" ou "Executar via xp_cmdshell"
-- As opções dos comandos são case sensitive
 
-- SQLCMD:
-- -S . = Servidor | -d curso = banco de dados | -E = Trusted Connection | -Q = query a ser executada | -o = Arquivo para salvar resultados | -W remove espaços em branco | -s"," = delimitar com , | -h-1 = remover a primeira linha de cabeçalho
!!sqlcmd -S . -d curso -E -Q "set nocount on; select * from amigos" -o "c:\tmp\amigos.csv" -W -s"," -h-1
 
-- BCP:
-- -c = tipo de informação texto | -t = termino de campo "," | -T = Trusted connection | -S = Servidor | -C ACP = Windows 1252 charset
!!bcp "select * from curso.dbo.amigos" queryout c:\tmp\amigos.csv -c -t, -T -S -C ACP
 
 
 
------------------------------------------
-- Importando um CSV para o SQL
------------------------------------------
-- Deletar a tabela para não duplicar dados após a importação
delete amigos
 
-- Importar dados
bulk insert amigos from 'C:\tmp\amigos.csv' with (fieldterminator = ',', rowterminator = '\n', firstrow = 1, codepage = 'acp')
 
select * from amigos