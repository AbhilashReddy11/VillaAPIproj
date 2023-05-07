using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using VillaAPI_Web.Models.Dto;

namespace VillaAPI_Web.Models.VM
{
	public class VillaNumberCreateVM
	{
		public VillaNumberCreateVM()
		{
			VillaNumber = new VillaNumberCreateDTO();
		}
		public VillaNumberCreateDTO VillaNumber { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> VillaList { get; set; }
	}
}
