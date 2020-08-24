using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainService.Domain.Models
{

    public class ConstellationModel : AModel
    {

      [NotMapped]
      public List<StarModel> Stars {get;set;}

      public string Description {get;set;}

      public ConstellationModel(){

        Stars = new List<StarModel>();

      }

    }

}
