﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Application.Interfaces;
using TheatricalPlayersRefactoringKata.Application.Strategy;
using TheatricalPlayersRefactoringKata.Domain.Entities;
using TheatricalPlayersRefactoringKata.Domain.Enum;

namespace TheatricalPlayersRefactoringKata.Application.Factory
{
    public class InvoicePrintFactory : IInvoicePrintFactory
    {


        public IInvoicePrint GetPrintType(PrintType type)
        {
            switch (type)
            {
                case PrintType.XML:
                    return new InvoicePrintXML();
                case PrintType.Text:
                    return new InvoicePrintText();
                default:
                    throw new Exception("unknown Print type: " + type.ToString());
            }
        }
    }
}