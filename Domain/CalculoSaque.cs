using Entidades;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class CalculoSaque
    {
      
        public string Saque(Valores obj)
        {
            var resp = new SaqueResponse();
            List<ListaNotas> list = new List<ListaNotas>();
            var cedulas = new NotasSaque();


            list.Add(new ListaNotas { Cedulas = 100.00, Quantidade = 50 });
            list.Add(new ListaNotas { Cedulas = 50.00, Quantidade = 50 });
            list.Add(new ListaNotas { Cedulas = 20.00, Quantidade = 50 });
            list.Add(new ListaNotas { Cedulas = 10.00, Quantidade = 50 });


            if (obj.ValorSolicitado == 30)
            {
                
                foreach (var item in list)
                {
                   if(item.Cedulas == 20)
                   {
                        if(item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas1 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$20,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }
                       
                   }
                   if(item.Cedulas == 10)
                   {
                        if (item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas2 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$10,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }
                   }

                   if(cedulas.Cedulas1 > 0 && cedulas.Cedulas2 > 0)
                    {
                        return resp.mensagem = $"Saque autorizado de R${obj.ValorSolicitado},00 , o caixa entregará 1 nota de R${cedulas.Cedulas1},00 + 1 nota de R${cedulas.Cedulas2},00";
                    }

                }

            }
            else if (obj.ValorSolicitado == 60)
            {
                foreach (var item in list)
                {
                    if (item.Cedulas == 50)
                    {
                        if (item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas1 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$50,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }

                    }
                    if (item.Cedulas == 10)
                    {
                        if (item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas2 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$10,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }
                    }

                    if (cedulas.Cedulas1 > 0 && cedulas.Cedulas2 > 0)
                    {
                        return resp.mensagem = $"Saque autorizado de R${obj.ValorSolicitado},00, o caixa entregará 1 nota de R${cedulas.Cedulas1},00 +  1 nota de R${cedulas.Cedulas2},00";
                    }

                }

            }
            else if (obj.ValorSolicitado == 80)
            {
                foreach (var item in list)
                {
                    if (item.Cedulas == 50)
                    {
                        if (item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas1 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$50,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }

                    }
                    if (item.Cedulas == 10)
                    {
                        if (item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas2 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$10,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }
                    }
                    if (item.Cedulas == 20)
                    {
                        if (item.Quantidade - 1 > 0)
                        {
                            cedulas.Cedulas3 = item.Cedulas;
                        }
                        else
                        {
                            return resp.mensagem = "NÃO HÁ NOTAS DE R$20,00 SUFICIENTES PARA O VALOR SOLICITADO";
                        }
                    }

                    if (cedulas.Cedulas1 > 0 && cedulas.Cedulas2 > 0 && cedulas.Cedulas3 > 0)
                    {
                        return resp.mensagem = $"Saque autorizado de R${obj.ValorSolicitado},00, o caixa entregará 1 nota de R${cedulas.Cedulas1},00 + 1 nota de R${cedulas.Cedulas2},00 + 1 nota de R${cedulas.Cedulas3},00";
                    }

                }
            }
            else
            {
                return resp.mensagem = "12";
            }

            return resp.mensagem;


        }

      
    }
}
