SELECT * FROM Filmes
SELECT * FROM FilmesGenero
SELECT * FROM Generos
SELECT * FROM Atores
SELECT * FROM ElencoFilme

-- 1

SELECT 
	Nome,
	Ano
FROM Filmes

-- 2

SELECT 
	Nome,
	Ano,
	Duracao
FROM Filmes
ORDER BY Ano ASC 

-- 3 

SELECT 
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Nome = 'De volta para o Futuro'

-- 4

SELECT 
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Ano = 1997

-- 5

SELECT 
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Ano LIKE '2%'

-- 6

SELECT 
	Nome,
	Ano,
	Duracao
FROM filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC


-- 7

SELECT 
	Ano,
	 COUNT(*) Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC

-- 8

SELECT 
	PrimeiroNome,
	UltimoNome,
	Genero
FROM Atores
WHERE Genero = 'M'

-- 9 

SELECT 
	PrimeiroNome,
	UltimoNome,
	Genero
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome

-- 10

SELECT 
	F.Nome AS Nome, G.Genero AS Genero
FROM Filmes AS F
INNER JOIN FilmesGenero AS FG ON F.id = FG.IdFilme
INNER JOIN Generos AS G ON FG.IdGenero = G.id;

-- 11

SELECT 
	F.Nome AS Nome, G.Genero AS Genero
FROM Filmes AS F
INNER JOIN FilmesGenero AS FG ON F.id = FG.IdFilme
INNER JOIN Generos AS G ON FG.IdGenero = G.id
WHERE G.Genero = 'Mistério'

-- 12

SELECT 
    F.Nome AS Nome,
    A.PrimeiroNome AS PrimeiroNome,
    A.UltimoNome AS UltimoNome,
    EF.Papel AS Papel
FROM 
    Filmes AS F
INNER JOIN ElencoFilme AS EF ON F.id = EF.IdFilme
INNER JOIN Atores AS A ON EF.IdAtor = A.Id;










