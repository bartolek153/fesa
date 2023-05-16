select count(*)
from filmes_tmp;

select * into #movies
from filmes_tmp
select * from filmes_tmp

go;

create or alter procedure sp_normalizacao_db as 
begin

	declare @duplicados int;
	
	go;

	create view vw_filmes_duplicados as 
	select id 
	from filmes_tmp
	group by id
	having count(*) > 1;

	go;

	-- remove registros duplicados
	delete filmes_tmp 
	where id in (vw_filmes_duplicados);
	
	select @duplicados = count(*)
	from vw_filmes_duplicados;

	print cast(@duplicados as varchar(64)) + ' registros duplicados removidos.'

	go;
	
	-- cria tabelas de destino

	create table filmes (
		id int primary key,
		titulo varchar(256),
		sinopse text,
		popularidade decimal(10,3),
		data_lancamento date,
		orcamento float,
		receita float,
		tempo_duracao float,
		pontuacao_media_votacao decimal(3,1),
		contagem_votos int,
		caminho_poster text,
		caminho_backdrop text,

		genero int foreign key references generos(id),
		lingua_origem char(2) foreign key references linguas(lingua)
		status int foreign key references status(id)
		produtoras int foreign key references produtoras(id)
	);

	create table generos (
		id int identity(1,1) primary key,
		descricao varchar(256)
	);

	create table linguas (
		lingua char(2) primary key,
		descricao varchar(256)
	);

	create table classificacao_duracao (
		id int identity(1,1) primary key,
		descricao varchar(256)
	);

	create table produtoras (
		id int identity(1,1) primary key,
		nome varchar(256)
	);

	create table status (
		id int identity(1,1) primary key,
		descricao varchar(256)
	);

	go;

	-- extrai tabela de generos

	declare @genero varchar(256);

	declare crs_generos cursor for 
	select distinct genero
	from filmes_tmp;

	open crs_generos;

	fetch next from crs_generos into @genero;
	while @@FETCH_STATUS = 0
	begin
		insert into generos (descricao)
		values (@genero);

		fetch next from crs_generos into @genero;
	end

	close crs_generos;
	deallocate crs_generos;

	go;

	-- insere linguas na tabela de linguas

	INSERT INTO linguas (id, descricao)
	VALUES
		('ab', 'Abcázio'),
		('af', 'Afrikaans'),
		('ak', 'Akan'),
		('am', 'Amárico'),
		('an', 'Aragonês'),
		('ar', 'Árabe'),
		('as', 'Assamês'),
		('av', 'Avar'),
		('ay', 'Aimará'),
		('az', 'Azeri'),
		('ba', 'Bashkir'),
		('be', 'Bielorrusso'),
		('bg', 'Búlgaro'),
		('bi', 'Bislamá'),
		('bm', 'Bambara'),
		('bn', 'Bengali'),
		('bo', 'Tibetano'),
		('bs', 'Bósnio'),
		('ca', 'Catalão'),
		('ce', 'Checheno'),
		('ch', 'Chamorro'),
		('cn', 'Chinês'),
		('co', 'Córsico'),
		('cr', 'Cree'),
		('cs', 'Tcheco'),
		('cv', 'Chuvash'),
		('cy', 'Galês'),
		('da', 'Dinamarquês'),
		('de', 'Alemão'),
		('dv', 'Divehi'),
		('dz', 'Dzongkha'),
		('el', 'Grego'),
		('en', 'Inglês'),
		('eo', 'Esperanto'),
		('es', 'Espanhol'),
		('et', 'Estoniano'),
		('eu', 'Basco'),
		('fa', 'Persa'),
		('ff', 'Fula'),
		('fi', 'Finlandês'),
		('fj', 'Fijiano'),
		('fo', 'Feroês'),
		('fr', 'Francês'),
		('fy', 'Frísio'),
		('ga', 'Irlandês'),
		('gd', 'Gaélico Escocês'),
		('gl', 'Galego'),
		('gn', 'Guarani'),
		('gu', 'Gujarati'),
		('gv', 'Manx'),
		('ha', 'Hauçá'),
		('he', 'Hebraico'),
		('hi', 'Hindi'),
		('hr', 'Croata'),
		('ht', 'Crioulo Haitiano'),
		('hu', 'Húngaro'),
		('hy', 'Armênio'),
		('ia', 'Interlíngua'),
		('id', 'Indonésio'),
		('ie', 'Interlingue'),
		('ig', 'Igbo'),
		('ii', 'Yi Sichuan'),
		('is', 'Islandês'),
		('it', 'Italiano'),
		('iu', 'Inuktitut'),
		('ja', 'Japonês'),
		('jv', 'Javanês'),
		('ka', 'Georgiano'),
		('kg', 'Kongo'),
		('ki', 'Quicuio'),
		('kk', 'Cazaque'),
		('kl', 'Groenlandês'),
		('km', 'Khmer'),
		('kn', 'Canarim'),
		('ko', 'Coreano'),
		('ks', 'Caxemira'),
		('ku', 'Curdo'),
		('kw', 'Córnico'),
		('ky', 'Quirguiz'),
		('la', 'Latim'),
		('lb', 'Luxemburguês'),
		('lg', 'Luganda'),
		('li', 'Limburguês'),
		('ln', 'Lingala'),
		('lo', 'Lao'),
		('lt', 'Lituano'),
		('lv', 'Letão'),
		('mg', 'Malgaxe'),
		('mh', 'Marshalês'),
		('mi', 'Maori'),
		('mk', 'Macedônio'),
		('ml', 'Malaiala'),
		('mn', 'Mongol'),
		('mo', 'Moldávio'),
		('mr', 'Marathi'),
		('ms', 'Malaio'),
		('mt', 'Maltês'),
		('my', 'Birmanês'),
		('nb', 'Norueguês Bokmål'),
		('ne', 'Nepalês'),
		('nl', 'Holandês'),
		('nn', 'Norueguês Nynorsk'),
		('no', 'Norueguês'),
		('nv', 'Navajo'),
		('ny', 'Chewa'),
		('oc', 'Occitano'),
		('oj', 'Ojíbua'),
		('om', 'Oromo'),
		('or', 'Oriá'),
		('os', 'Osseta'),
		('pa', 'Panjabi'),
		('pi', 'Páli'),
		('pl', 'Polonês'),
		('ps', 'Pashto'),
		('pt', 'Português'),
		('qu', 'Quíchua'),
		('rm', 'Romanche'),
		('rn', 'Kirundi'),
		('ro', 'Romeno'),
		('ru', 'Russo'),
		('rw', 'Kinyarwanda'),
		('sa', 'Sânscrito'),
		('sc', 'Sardo'),
		('sd', 'Sindi'),
		('se', 'Sami do Norte'),
		('sg', 'Sango'),
		('sh', 'Servo-Croata'),
		('si', 'Sinhala'),
		('sk', 'Eslovaco'),
		('sl', 'Esloveno'),
		('sm', 'Samoano'),
		('sn', 'Shona'),
		('so', 'Somali'),
		('sq', 'Albanês'),
		('sr', 'Sérvio'),
		('ss', 'Siswati'),
		('st', 'Soto do Sul'),
		('su', 'Sundanês'),
		('sv', 'Sueco'),
		('sw', 'Suaíli'),
		('ta', 'Tâmil'),
		('te', 'Telugu'),
		('tg', 'Tajique'),
		('th', 'Tailandês'),
		('ti', 'Tigrínia'),
		('tk', 'Turcomeno'),
		('tl', 'Tagalo'),
		('tn', 'Setswana'),
		('to', 'Tonganês'),
		('tr', 'Turco'),
		('ts', 'Tsonga'),
		('tt', 'Tártaro'),
		('tw', 'Twi'),
		('ty', 'Taitiano'),
		('ug', 'Uigur'),
		('uk', 'Ucraniano'),
		('ur', 'Urdu'),
		('uz', 'Uzbeque'),
		('vi', 'Vietnamita'),
		('wo', 'Wolof'),
		('xh', 'Xhosa'),
		('xx', 'Desconhecido'),
		('yi', 'Ídiche'),
		('yo', 'Iorubá'),
		('za', 'Zhuang'),
		('zh', 'Chinês'),
		('zu', 'Zulu');


	-- insere classificacao de duracao na tabela de classificacao_duracao

	insert into classificacao_duracao (id, descricao)
	values 
		(1, 'curta-metragem'),  -- < 40 min
		(2, 'media-metragem'),  -- > 40 min e < 60 min
		(3, 'longa-metragem'),  -- > 90 min e < 150 min
		(4, 'epica-metragem')   -- > 180 min 

	-- insere status na tabela de status

	declare @status varchar(256);

	declare crs_status cursor for
	select distinct status
	from filmes_tmp;

	open crs_status;

	fetch next from crs_status into @status;
	while @@FETCH_STATUS = 0
	begin
		insert into status (descricao)
		values (@status);

		fetch next from crs_status into @status;
	end

	close crs_status;
	deallocate crs_status;


	-- insere produtoras na tabela de produtoras

	declare @produtora varchar(256);

	declare crs_produtoras cursor for
	select distinct empresas_produtoras
	from filmes_tmp;

	open crs_produtoras;

	fetch next from crs_produtoras into @produtora;
	while @@FETCH_STATUS = 0
	begin
		insert into produtoras (nome)
		values (@produtora);

		fetch next from crs_produtoras into @produtora;
	end

	close crs_produtoras;
	deallocate crs_produtoras;
	
	-- classifica os filmes de acordo com o tempo de duração
	-- e faz update na tabela de filme
	create function dbo.classifica_duracao (@tempo float)
	returns int as begin 
		declare @categoria int;

		if @tempo < 40
			set @categoria = 1;
		else if @tempo < 60
			set @categoria = 2;
		else if @tempo < 90
			set @categoria = 3;
		else
			set @categoria = 4;
	end;


end;

go;


