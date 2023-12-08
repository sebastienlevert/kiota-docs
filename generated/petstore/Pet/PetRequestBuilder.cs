using Microsoft.Kiota.Abstractions;
using PetStore.Pet.FindByStatus;
using PetStore.Pet.FindByTags;
using PetStore.Pet.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace PetStore.Pet {
    /// <summary>
    /// Builds and executes requests for operations under \pet
    /// </summary>
    public class PetRequestBuilder : BaseRequestBuilder {
        /// <summary>The findByStatus property</summary>
        public FindByStatusRequestBuilder FindByStatus { get =>
            new FindByStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The findByTags property</summary>
        public FindByTagsRequestBuilder FindByTags { get =>
            new FindByTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the PetStore.pet.item collection</summary>
        public WithPetItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("petId", position);
            return new WithPetItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new PetRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pet", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PetRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pet", rawUrl) {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PetRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new petRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public PetRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PetRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new petRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public PetRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
