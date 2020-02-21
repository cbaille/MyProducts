(function () {
	$(function () {

		$('.delete-product').click(function () {
			var productId = $(this).attr("data-product-id");
			var productName = $(this).attr('data-product-name');

			deleteClient(productId, productName);
		});

		$('.edit-product').click(function (e) {
			var productId = $(this).attr("data-product-id");
			e.preventDefault();
			abp.ajax({
				url: '/Products/EditProductModal?productId=' + productId,
				type: 'POST',
				contentType: 'application/html',
				success: function (content) {
					$('#ProductEditModal div.modal-content').html(content);
				},
				error: function (e) { }
			});
		});

		function refreshProductList() {
			location.reload(true);
		}

		function deleteClient(productId, productName) {
			abp.message.confirm(
				abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'MyProduct'), productName),
				function (isConfirmed) {
					if (isConfirmed) {
						abp.services.app.product.delete(productId)({ id: productId })
							.done(function () {
							refreshProductList();
						});
					}
				}
			);
		}

	});
})();