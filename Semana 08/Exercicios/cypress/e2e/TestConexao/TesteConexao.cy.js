//1 – Em Calc Simples o usuário fará inicialmente uma Soma entre 10 e 123 e na sequência uma subtração de 70 em 97.
//Após isso ele preenche esses dois dados na tela usando os seguintes nomes, respectivamente, Pássaros e Peixes.

context("testeConexao", () => {
  it("TesteCoenxao", () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");

    cy.get("#txtN1").type(10);
    cy.get("#txtN2").type(123);

    cy.get("input").contains("Calcular").click();

    cy.get("#lbResultado")
      .invoke("text")
      .then(($result) => {
        expect($result).to.be.equal("133");
      });

    cy.get("input").contains("Limpar").click();

    cy.get("#txtN1").type(97);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(70);

    cy.get("input").contains("Calcular").click();

    cy.get("#lbResultado")
      .invoke("text")
      .then(($result) => {
        expect($result).to.be.equal("27");
      });

    cy.get("input").contains("Limpar").click();

    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");

    cy.get("#txtN1").type("Pássaros");
    cy.get("#txtV1").type(133);

    cy.get("#txtN2").type("Peixes");
    cy.get("#txtV2").type(27);

    cy.get("input").contains("Enviar").click();

    cy.get("table tbody tr").should("have.length", 3);
  });

  //2 – Em Calc Simples o usuário fará inicialmente uma Multiplicação entre 10 e 100, na sequência uma divisão de 90 por 3, uma soma 125 com 25 e uma subtração de 1 para 2.
  //Após isso ele preenche esses dois dados na tela usando os seguintes nomes respectivamente Ração, Petiscos, Coleiras e Remédios.
  it("TesteConexao01", () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");

    cy.get("#txtN1").type(10);
    cy.get("#rbFuncao_2").click();
    cy.get("#txtN2").type(100);

    cy.get("input").contains("Calcular").click();

    cy.get("#lbResultado")
      .invoke("text")
      .then(($result) => {
        expect($result).to.be.equal("1000");
      });

    cy.get("input").contains("Limpar").click();

    cy.get("#txtN1").type(90);
    cy.get("#rbFuncao_3").click();
    cy.get("#txtN2").type(3);

    cy.get("input").contains("Calcular").click();

    cy.get("#lbResultado")
      .invoke("text")
      .then(($result) => {
        expect($result).to.be.equal("30");
      });

    cy.get("input").contains("Limpar").click();

    cy.get("#txtN1").type(125);
    cy.get("#rbFuncao_0").click();
    cy.get("#txtN2").type(25);

    cy.get("input").contains("Calcular").click();

    cy.get("#lbResultado")
      .invoke("text")
      .then(($result) => {
        expect($result).to.be.equal("150");
      });

    cy.get("input").contains("Limpar").click();

    cy.get("#txtN1").type(2);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(1);

    cy.get("input").contains("Calcular").click();

    cy.get("#lbResultado")
      .invoke("text")
      .then(($result) => {
        expect($result).to.be.equal("1");
      });

    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");

    cy.get("#txtN1").type("Racão");
    cy.get("#txtV1").type(1000);

    cy.get("#txtN2").type("Petiscos");
    cy.get("#txtV2").type(30);

    cy.get("#txtN3").type("Coleira");
    cy.get("#txtV3").type(150);

    cy.get("#txtN4").type("Remédios");
    cy.get("#txtV4").type(1);

    cy.get("input").contains("Enviar").click();

    cy.get("table tbody tr").should("have.length", 5);
  });
});
