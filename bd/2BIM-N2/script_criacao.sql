use master

if db_id('tmdb') is not null
    drop database tmdb
go

create database tmdb
go

use tmdb
go;

create database tmdb;
drop database tmdb;
use tmdb;
drop table tbl_filmes_temp;

CREATE TABLE tbl_filmes_temp (
   id INT PRIMARY KEY,
   titulo VARCHAR(255),
   generos VARCHAR(255),
   lingua_origem VARCHAR(50),
   sinopse TEXT,
   popularidade DECIMAL(10,3),
   empresas_produtoras VARCHAR(255),
   data_lancamento DATE,
   orcamento FLOAT,
   receita FLOAT,
   tempo_duracao FLOAT,
   status VARCHAR(50),
   tags TEXT,
   pontuacao_media_votacao DECIMAL(3,1),
   contagem_votos INT,
   creditos TEXT,
   palavras_chaves VARCHAR(255),
   caminho_poster VARCHAR(255),
   caminho_backdrop VARCHAR(255),
   recomendacoes TEXT
);

BULK INSERT tbl_filmes_temp
FROM '/movies.csv'
WITH (
    fieldterminator = ',',
    rowterminator = '0x0A',
    firstrow = 2,
    tablock
);