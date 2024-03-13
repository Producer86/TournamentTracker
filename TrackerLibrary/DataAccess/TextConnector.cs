﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to a text file.
        /// <summary>
        /// Saves a new Prize to a text file.
        /// </summary>
        /// <param name="model">The PrizeModel to save.</param>
        /// <returns>The PrizeModel with it's Id set.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //model.Id = 1;

            return model;
        }
    }
}