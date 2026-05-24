var t = Model.Tables["_Medidas"];

t.AddMeasure("Selic Atual", "CALCULATE(LASTNONBLANK(fSelic[valor],1),ALL(dCalendario))");
t.AddMeasure("Selic Media 12m", "CALCULATE(AVERAGE(fSelic[valor]),DATESINPERIOD(dCalendario[data],LASTDATE(dCalendario[data]),-12,MONTH))");
t.AddMeasure("IPCA Ultimo 12m", "CALCULATE(LASTNONBLANK(fIpca[valor],1),ALL(dCalendario))");
t.AddMeasure("IPCA Media 12m", "CALCULATE(AVERAGE(fIpca[valor]),DATESINPERIOD(dCalendario[data],LASTDATE(dCalendario[data]),-12,MONTH))");
t.AddMeasure("Cambio Atual", "CALCULATE(LASTNONBLANK(fCambio[valor],1),ALL(dCalendario))");
t.AddMeasure("Cambio Media 12m", "CALCULATE(AVERAGE(fCambio[valor]),DATESINPERIOD(dCalendario[data],LASTDATE(dCalendario[data]),-12,MONTH))");
t.AddMeasure("Cambio Minimo", "CALCULATE(MIN(fCambio[valor]),ALL(dCalendario))");
t.AddMeasure("Cambio Maximo", "CALCULATE(MAX(fCambio[valor]),ALL(dCalendario))");
t.AddMeasure("Credito PF Atual", "CALCULATE(LASTNONBLANK(fCreditoPF[valor],1),ALL(dCalendario))");
t.AddMeasure("Credito PJ Atual", "CALCULATE(LASTNONBLANK(fCreditoPJ[valor],1),ALL(dCalendario))");
t.AddMeasure("Credito Total", "[Credito PF Atual] + [Credito PJ Atual]");
t.AddMeasure("Inadimplencia PF", "CALCULATE(LASTNONBLANK(fInadimplenciaPF[valor],1),ALL(dCalendario))");
t.AddMeasure("Inadimplencia PJ", "CALCULATE(LASTNONBLANK(fInadimplenciaPJ[valor],1),ALL(dCalendario))");
t.AddMeasure("IBCBr Ultimo", "CALCULATE(LASTNONBLANK(fIBCBr[valor],1),ALL(dCalendario))");
t.AddMeasure("IBCBr Var 12m", "DIVIDE([IBCBr Ultimo] - CALCULATE(LASTNONBLANK(fIBCBr[valor],1),DATEADD(dCalendario[data],-12,MONTH)),CALCULATE(LASTNONBLANK(fIBCBr[valor],1),DATEADD(dCalendario[data],-12,MONTH)))");
t.AddMeasure("Reservas Atual", "CALCULATE(LASTNONBLANK(fReservas[valor],1),ALL(dCalendario))");