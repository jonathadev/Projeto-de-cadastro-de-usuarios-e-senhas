CREATE TABLE tb_itens_venda (quantidade int NOT NULL, id_produto
int NOT NULL, id_venda int NOT NULL, valor decimal(15, 2) NOT NULL,
id_item int IDENTITY(1, 1) NOT NULL, PRIMARY KEY (id_item));

CREATE TABLE tb_venda (id_venda int IDENTITY(1, 1) NOT NULL, valor
decimal(15, 2), desconto decimal(15, 2),
valor_pago decimal(15, 2), id_pessoa int, PRIMARY KEY (id_venda));

ALTER TABLE tb_venda ADD CONSTRAINT FKtb_venda366981 FOREIGN KEY
(id_pessoa) REFERENCES tb_pessoa (id_pessoa);

ALTER TABLE tb_itens_venda ADD CONSTRAINT FKtb_itens_v307950
FOREIGN KEY (id_produto) REFERENCES tb_produto (id_produto);

ALTER TABLE tb_itens_venda ADD CONSTRAINT FKtb_itens_v919744
FOREIGN KEY (id_venda) REFERENCES tb_venda (id_venda);


