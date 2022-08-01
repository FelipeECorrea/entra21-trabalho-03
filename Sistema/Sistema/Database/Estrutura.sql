CREATE TABLE torneios (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25),
	modo_jogo VARCHAR(50),
	modo_presencial VARCHAR(50),
	data_inicio DATETIME2,
	data_termino DATETIME2,
	categoria VARCHAR(20),
	premiacao VARCHAR(100));

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

	FOREIGN KEY(id_time) REFERENCES times(id),
	FOREIGN KEY(id_torneio) REFERENCES torneios(id));

CREATE TABLE partidas (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	partida_escolhida VARCHAR(100),
	mapa_1 VARCHAR(25),
	mapa_2 VARCHAR(25),
	mapa_3 VARCHAR(25));
	
CREATE TABLE contas (
	id INT PRIMARY KEY IDENTITY(1,1),
	usuario VARCHAR(15) NOT NULL,
	email VARCHAR(50) NOT NULL,
	senha VARCHAR(20) NOT NULL
);

INSERT INTO contas VALUES
	('Felipe Corrêa','pessoal.fec@gmail.com', '1998');
	
INSERT INTO grupos VALUES
	('4','3', '1');

DROP TABLE grupos;

SELECT * FROM contas;
SELECT * FROM torneios;
SELECT * FROM times;
SELECT * FROM transmissoes;
SELECT * FROM grupos;
SELECT * FROM partidas;

