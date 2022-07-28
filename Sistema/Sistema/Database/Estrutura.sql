CREATE TABLE torneios (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25),
	modo_presencial BIT,
	data_inicio DATETIME2,
	data_termino DATETIME2,
	premiacao DECIMAL(10,2));

CREATE TABLE transmissoes (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_torneio INTEGER,
	nome_live VARCHAR(50),
	nome_narrador VARCHAR(50),
	plataforma VARCHAR(25),
	idioma_portugues BIT,
	idioma_ingles BIT,
	idioma_espanhol BIT,

	FOREIGN KEY(id_torneio) REFERENCES torneios(id));

CREATE TABLE times (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25),
	nacionalidade VARCHAR(20),
	data_criacao DATETIME2);

CREATE TABLE jogadores (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_time INTEGER,
	nick VARCHAR(25),
	email VARCHAR(70),
	senha VARCHAR(50),
	patente VARCHAR(25),
	
	FOREIGN KEY(id_time) REFERENCES times(id));

CREATE TABLE grupos (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_time INTEGER,
	id_torneio INTEGER,
	id_transmissao INTEGER,

	FOREIGN KEY(id_time) REFERENCES times(id),
	FOREIGN KEY(id_torneio) REFERENCES torneios(id),
	FOREIGN KEY(id_transmissao) REFERENCES transmissoes(id));

CREATE TABLE partidas (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	partida_sorteada VARCHAR(100),
	mapa_mirage BIT,
	mapa_dust2 BIT,
	mapa_overpass BIT,
	mapa_vertigo BIT,
	mapa_nuke BIT,
	mapa_inferno BIT,
	mapa_ancient BIT
	
	FOREIGN KEY(id_grupos) REFERENCES grupos(id));
	
CREATE TABLE contas (
	usuario VARCHAR(15),
	email VARCHAR(50),
	senha VARCHAR(15)
);

INSERT INTO contas VALUES
	('Felipe Corrêa','pessoal.fec@gmail.com', '1998');

SELECT * FROM contas;