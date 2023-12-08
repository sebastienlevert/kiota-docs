using Microsoft.Kiota.Abstractions;
using PetStore.Store.Inventory;
using PetStore.Store.Order;
using PetStore.Store.Subscribe;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace PetStore.Store {
    /// <summary>
    /// Builds and executes requests for operations under \store
    /// </summary>
    public class StoreRequestBuilder : BaseRequestBuilder {
        /// <summary>The inventory property</summary>
        public InventoryRequestBuilder Inventory { get =>
            new InventoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The order property</summary>
        public OrderRequestBuilder Order { get =>
            new OrderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscribe property</summary>
        public SubscribeRequestBuilder Subscribe { get =>
            new SubscribeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new StoreRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StoreRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/store", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new StoreRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StoreRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/store", rawUrl) {
        }
    }
}
