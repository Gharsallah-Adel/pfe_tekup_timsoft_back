using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{

    [Route("Document")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {

            _documentService = documentService;

        }

        [HttpPost]
        [Route("AddDocument")]
        public IActionResult AddDocument(DocumentDTO document)

        {



            return Ok(_documentService.AddDocument(document));

        }
         [HttpPut]
        [Route("UpdateFormationById")]

        public IActionResult UpdateDocumentById([FromBody] Document document, int id)
        {
            return Ok(_documentService.updateDocumentById(document, id));
            }

        [HttpDelete]
        [Route("DeleteDocumentById")]

        public IActionResult RemoveDocument(int id)
        {
            return Ok(_documentService.RemoveDocument(id));


        }

        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetDocuments")]

        public IActionResult GetDocuments()
        {
            return Ok(_documentService.GetDocuments());
        }





    }
}