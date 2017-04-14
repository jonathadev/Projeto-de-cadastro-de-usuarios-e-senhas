CREATE TABLE tb_status_pagamento (id_status int IDENTITY NOT NULL, status varchar(50) NOT NULL, PRIMARY KEY (id_status));

CREATE TABLE tb_contas_receber (id_conta int IDENTITY(1, 1) NOT NULL, data_compra date NOT NULL, data_vencimento date NOT NULL, data_pagamento date, id_venda int NOT NULL, id_status int NOT NULL, PRIMARY KEY (id_conta));

ALTER TABLE tb_contas_receber ADD CONSTRAINT FKcontas_rec225305 FOREIGN KEY (id_venda) REFERENCES tb_venda (id_venda);

ALTER TABLE tb_contas_receber ADD CONSTRAINT FKcontas_rec366784 FOREIGN KEY (id_status) REFERENCES tb_status_pagamento (id_status);