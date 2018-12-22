function display(stock) {
	var modal = $('#divimage');
	modal.css('display', 'block');
	$('#modalimg').attr("src", stock.src);
	$("#caption").html(stock.alt);
	modal.click(function () {
		modal.css('display', 'none');
	});
}