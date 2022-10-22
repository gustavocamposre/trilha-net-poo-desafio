using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


            Iphone i1 = new Iphone(numero: "Iphone",modelo: "13 pro",imei: "87654321", memoria: 6);
            i1.Ligar();
            i1.ReceberLigacao();
            i1.InstalarAplicativo(nomeApp:"Whatsapp");
            
            
            Nokia n1 = new Nokia(numero:" Nokia ",modelo:"Advanced", imei:"12345678",memoria: 4);
            n1.Ligar();
            n1.ReceberLigacao();
            n1.InstalarAplicativo(nomeApp:"Telegram");

