use master;

if db_id('tmdb') is not null
begin
    drop database tmdb
end;
go;

create database tmdb;
go;

use tmdb;
go;

use tmdb;

set dateformat YMD;

create table filmes_tmp (
   id INT,
   titulo NVARCHAR(MAX),
   sinopse TEXT,
   generos NVARCHAR(MAX),
   lingua_origem NVARCHAR(MAX),
   popularidade DECIMAL(10,3),
   produtora NVARCHAR(MAX),
   data_lancamento DATE,
   orcamento DECIMAL(10,3),
   receita DECIMAL(10,3),
   tempo_duracao DECIMAL(10,3),
   status NVARCHAR(50),
   tags NVARCHAR(MAX),
   pontuacao_media_votacao DECIMAL(3,1),
   contagem_votos DECIMAL(10,3),
   creditos NVARCHAR(MAX),
   palavras_chaves NVARCHAR(MAX),
   caminho_poster NVARCHAR(MAX),
   caminho_backdrop NVARCHAR(MAX),
   recomendacoes TEXT
);

BULK INSERT filmes_tmp
FROM './filmes.csv'
WITH (
    fieldterminator = ',',
    rowterminator = '0x0A',
    firstrow = 2,
    tablock
);
