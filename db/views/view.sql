--Criando views identicas as tabelas
--view que lista todos os campos da tabela
--restringindo somente os registros
create view vw_func_1 as
	select * from funcionarios f
	where f.func_salario > 600

--chamanda da view
select * from vw_func_1
order by func_dataNasc

--view que escolhe alguns campos da tablea
create view vw_func_2 as
	select f.func_id registro, f.func_nome nome, 
		   f.func_salario salario
	from funcionarios f

	--chamanda da view
select * from vw_func_2

-------------------------------------------------
-- fazendo joins com as views criadas
select * 
from vw_func_1 a
inner join setores s on a.setor_id = s.setor_id

------------------------------------------------
--fazendo joins com 2 views
create view vw_setor_1 as
	select * from setores

create view vw_func_3 as
	select func_id, func_nome, setor_id from funcionarios

--fazendo o join
select *
from vw_func_3 a
inner join vw_setor_1 b on a.setor_id = b.setor_id

--transformando em view
create view vw_junta_1 as
	select a.*, b.setor_nome
	from vw_func_3 a
	inner join vw_setor_1 b on a.setor_id = b.setor_id

select * from vw_junta_1