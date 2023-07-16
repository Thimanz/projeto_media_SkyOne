use alunosdb;

-- sem usar o dado de status calculando-o dentro do select
SELECT nome as "Nome do aluno", 
	   nota1 as "Nota do Primeiro Semestre", 
       nota2 as "Nota do Segundo Semestre", 
       media as "Média Anual", ano as "Ano", 
       CASE WHEN media > 6.5 THEN "Aprovado" ELSE "Reprovado" END AS "Status"
from t_aluno;

SELECT nome as "Nome do aluno", 
	   nota1 as "Nota do Primeiro Semestre", 
       nota2 as "Nota do Segundo Semestre", 
       media as "Média Anual", ano as "Ano",
       CASE WHEN media > 6.5 THEN "Aprovado" ELSE "Reprovado" END AS "Status"
FROM T_ALUNO
WHERE media > 6;