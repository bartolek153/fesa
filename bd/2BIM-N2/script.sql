
--
-- Retorna registros de filmes repetidos
-- 
CREATE VIEW vw_filmes_duplicados AS 
SELECT id 
FROM filmes_tmp
GROUP BY id
HAVING count(*) > 1;

GO;

-- 
-- Classifica os filmes de acordo com o tempo de duração
--
CREATE FUNCTION dbo.fn_get_classificacao_duracao (@tempo float)
RETURNS int AS BEGIN 
	IF @tempo < 40
		RETURN(1);
	ELSE IF @tempo < 90
		RETURN(2);
	ELSE IF @tempo < 180
		RETURN(3);
	ELSE
		RETURN(4);
END;

GO;

--
-- Traduz o status do filme para normalizar
--
CREATE FUNCTION dbo.fn_get_status (@status varchar(64))
RETURN int AS BEGIN
	IF @status = 'Released'
		RETURN(1);
	ELSE IF @status = 'Planned'
		RETURN(2);
	ELSE IF @status = 'In Production'
		RETURN(3);
	ELSE IF @status = 'Post Production'
		RETURN(4);
	ELSE IF @status = 'Canceled'
		RETURN(5);
	ELSE
		RETURN(0);
END

GO;

--
-- Procedimento principal de normalização do banco
--
CREATE OR ALTER procedure sp_normalizacao_db AS 
BEGIN

	PRINT('Iniciando normalização do banco de dados...')

	DECLARE @duplicados int;
	DECLARE @contagemRegistros int;
	DECLARE @genero varchar(256);
	DECLARE @status varchar(256);
	DECLARE @produtora varchar(256);

	--
	-- Conta quantidade de registros duplicados
	--
	SELECT @duplicados = count(*)
	FROM vw_filmes_duplicados;
	
	--
	-- Remove registros duplicados
	--
	DELETE filmes_tmp 
	WHERE id IN (vw_filmes_duplicados);
	
	--
	-- Conta quantidade de registros restantes
	--
	SELECT @contagemRegistros = count(*)
	FROM filmes_tmp;

	PRINT cast(@duplicados AS varchar(64)) + ' registros duplicados removidos.';
	PRINT cast(@contagemRegistros AS varchar(64)) + ' linhas restantes.';


	--	
	-- Cria tabelas base (normalizadas)
	--
	CREATE TABLE Filmes (
		id int identity(1,1) PRIMARY KEY,
		titulo varchar(256),
		sinopse text,
		popularidade decimal(10,3),
		data_lancamento date,
		orcamento float,
		receita float,
		tempo_duracao float,
		pontuacao_media_votacao decimal(10,3),
		contagem_votos int,

		genero int 					FOREIGN KEY REFERENCES Generos(id),
		lingua_origem char(2) 		FOREIGN KEY REFERENCES Linguas(id),
		classificacao_duracao int 	FOREIGN KEY REFERENCES ClassificacoesDuracao(id),
		produtora int 				FOREIGN KEY REFERENCES Produtoras(id),
		status int 					FOREIGN KEY REFERENCES Status(id)
	);

	CREATE TABLE Generos (
		id int NOT NULL identity(1,1) PRIMARY KEY,
		descricao varchar(256)
	);

	CREATE TABLE Linguas (
		id char(2) NOT NULL PRIMARY KEY,
		descricao varchar(256)
	);

	CREATE TABLE ClassificacoesDuracao (
		id int NOT NULL PRIMARY KEY,
		descricao varchar(256),
		tempo_minima int,
		tempo_maxima int
	);

	CREATE TABLE Produtoras (
		id int identity(1,1) PRIMARY KEY,
		nome varchar(256)
	);

	CREATE TABLE Status (
		id int NOT NULL PRIMARY KEY,
		descricao varchar(256)
	);

	PRINT 'Tabelas base criadas.';

	--
	-- Insere dados-mestres
	--
	INSERT INTO Linguas (id, descricao)
	VALUES
		('ab', 'Abcázio'), ('af', 'Afrikaans'), ('ak', 'Akan'), ('am', 'Amárico'), ('an', 'Aragonês'), ('ar', 'Árabe'), ('as', 'Assamês'),
		('av', 'Avar'), ('ay', 'Aimará'), ('az', 'Azeri'), ('ba', 'Bashkir'), ('be', 'Bielorrusso'), ('bg', 'Búlgaro'), ('bi', 'Bislamá'),
		('bm', 'Bambara'), ('bn', 'Bengali'), ('bo', 'Tibetano'), ('bs', 'Bósnio'), ('ca', 'Catalão'), ('ce', 'Checheno'), ('ch', 'Chamorro'),
		('cn', 'Chinês'), ('co', 'Córsico'), ('cr', 'Cree'), ('cs', 'Tcheco'), ('cv', 'Chuvash'), ('cy', 'Galês'), ('da', 'Dinamarquês'),
		('de', 'Alemão'), ('dv', 'Divehi'), ('dz', 'Dzongkha'), ('el', 'Grego'), ('en', 'Inglês'), ('eo', 'Esperanto'), ('es', 'Espanhol'),
		('et', 'Estoniano'), ('eu', 'Basco'), ('fa', 'Persa'), ('ff', 'Fula'), ('fi', 'Finlandês'), ('fj', 'Fijiano'), ('fo', 'Feroês'),
		('fr', 'Francês'), ('fy', 'Frísio'), ('ga', 'Irlandês'), ('gd', 'Gaélico Escocês'), ('gl', 'Galego'), ('gn', 'Guarani'), ('gu', 'Gujarati'),
		('gv', 'Manx'), ('ha', 'Hauçá'), ('he', 'Hebraico'), ('hi', 'Hindi'), ('hr', 'Croata'), ('ht', 'Crioulo Haitiano'), ('hu', 'Húngaro'),
		('hy', 'Armênio'), ('ia', 'Interlíngua'), ('id', 'Indonésio'), ('ie', 'Interlingue'), ('ig', 'Igbo'), ('ii', 'Yi Sichuan'), ('is', 'Islandês'),
		('it', 'Italiano'), ('iu', 'Inuktitut'), ('ja', 'Japonês'), ('jv', 'Javanês'), ('ka', 'Georgiano'), ('kg', 'Kongo'), ('ki', 'Quicuio'),
		('kk', 'Cazaque'), ('kl', 'Groenlandês'), ('km', 'Khmer'), ('kn', 'Canarim'), ('ko', 'Coreano'), ('ks', 'Caxemira'), ('ku', 'Curdo'),
		('kw', 'Córnico'), ('ky', 'Quirguiz'), ('la', 'Latim'), ('lb', 'Luxemburguês'), ('lg', 'Luganda'), ('li', 'Limburguês'), ('ln', 'Lingala'),
		('lo', 'Lao'), ('lt', 'Lituano'), ('lv', 'Letão'), ('mg', 'Malgaxe'), ('mh', 'Marshalês'), ('mi', 'Maori'), ('mk', 'Macedônio'), ('ml', 'Malaiala'),
		('mn', 'Mongol'), ('mo', 'Moldávio'), ('mr', 'Marathi'), ('ms', 'Malaio'), ('mt', 'Maltês'), ('my', 'Birmanês'), ('nb', 'Norueguês Bokmål'),
		('ne', 'Nepalês'), ('nl', 'Holandês'), ('nn', 'Norueguês Nynorsk'), ('no', 'Norueguês'), ('nv', 'Navajo'), ('ny', 'Chewa'), ('oc', 'Occitano'),
		('oj', 'Ojíbua'), ('om', 'Oromo'), ('or', 'Oriá'), ('os', 'Osseta'), ('pa', 'Panjabi'), ('pi', 'Páli'), ('pl', 'Polonês'), ('ps', 'Pashto'),
		('pt', 'Português'), ('qu', 'Quíchua'), ('rm', 'Romanche'), ('rn', 'Kirundi'), ('ro', 'Romeno'), ('ru', 'Russo'), ('rw', 'Kinyarwanda'),
		('sa', 'Sânscrito'), ('sc', 'Sardo'), ('sd', 'Sindi'), ('se', 'Sami do Norte'), ('sg', 'Sango'), ('sh', 'Servo-Croata'), ('si', 'Sinhala'),
		('sk', 'Eslovaco'), ('sl', 'Esloveno'), ('sm', 'Samoano'), ('sn', 'Shona'), ('so', 'Somali'), ('sq', 'Albanês'), ('sr', 'Sérvio'),
		('ss', 'Siswati'), ('st', 'Soto do Sul'), ('su', 'Sundanês'), ('sv', 'Sueco'), ('sw', 'Suaíli'), ('ta', 'Tâmil'), ('te', 'Telugu'),
		('tg', 'Tajique'), ('th', 'Tailandês'), ('ti', 'Tigrínia'), ('tk', 'Turcomeno'), ('tl', 'Tagalo'), ('tn', 'Setswana'), ('to', 'Tonganês'),
		('tr', 'Turco'), ('ts', 'Tsonga'), ('tt', 'Tártaro'), ('tw', 'Twi'), ('ty', 'Taitiano'), ('ug', 'Uigur'), ('uk', 'Ucraniano'), ('ur', 'Urdu'),
		('uz', 'Uzbeque'), ('vi', 'Vietnamita'), ('wo', 'Wolof'), ('xh', 'Xhosa'), ('xx', 'Desconhecido'), ('yi', 'Ídiche'), ('yo', 'Iorubá'),
		('za', 'Zhuang'), ('zh', 'Chinês'), ('zu', 'Zulu');

	INSERT INTO ClassificacaoDuracao (id, descricao, tempo_minimo, tempo_maximo)
	VALUES 
		(0, 'Desconhecido', NULL, NULL),
		(1, 'Curta-metragem', NULL, 40),  -- < 40 min
		(2, 'Média-metragem', 41, 90),  -- > 40 min e < 60 min
		(3, 'Longa-metragem', 91, 150),  -- > 90 min e < 150 min
		(4, 'Épica-metragem', 180, NULL)   -- > 180 min 

	INSERT INTO Status (id, descricao)
	VALUES
		(0, 'Desconhecido'),
		(1, 'Lançado'),
		(2, 'Planejado'),
		(3, 'Em produção'),
		(4, 'Pós-rodução'),
		(5, 'Cancelado')

	PRINT 'Dados-mestres inseridos.'

	--
	-- Normaliza tabela de generos
	--
	DECLARE crs_generos CURSOR FOR
	SELECT DISTINCT genero
	FROM filmes_tmp;

	OPEN crs_generos;

	FETCH NEXT FROM crs_generos INTO @genero;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Generos(descricao)
		VALUES (@genero);

		FETCH NEXT FROM crs_generos INTO @genero;
	END

	CLOSE crs_generos;
	DEALLOCATE crs_generos;

	--
	-- Normaliza tabela de produtoras
	--
	DECLARE crs_produtoras CURSOR FOR
	SELECT DISTINCT produtora
	FROM filmes_tmp;

	OPEN crs_produtoras;

	FETCH NEXT FROM crs_produtoras INTO @produtora;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO produtoras(nome)
		VALUES (@produtora);

		FETCH NEXT FROM crs_produtoras INTO @produtora;
	END

	CLOSE crs_produtoras;
	DEALLOCATE crs_produtoras;

	--
	-- Normaliza tabela de filmes
	--
	INSERT INTO Filmes 
	SELECT 
		id, titulo, sinopse, popularidade, data_lancamento, orcamento, receita,
		tempo_duracao, pontuacao_media_votacao, contagem_votos,
		(SELECT id FROM Generos WHERE descricao = genero), lingua_origem,
		dbo.fn_get_classificacao_duracao(tempo_duracao),
		(SELECT id FROM Produtoras WHERE nome = empresas_produtoras),
		dbo.fn_get_status(status)
	FROM filmes_tmp;

	PRINT 'Tabelas normalizadas.';

	--
	-- FIM SP
	--
END;

GO;

EXEC sp_normalizacao_db;
PRINT 'Fim da execução do procedimento de normalização.'