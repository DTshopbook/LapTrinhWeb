﻿window.onload = function () {
 
var chart = new CanvasJS.Chart("chartContainer", {
	theme: "light1", // "light1", "light2", "dark1", "dark2"
	exportEnabled: true,
	animationEnabled: true,
	title: {
		text: "Indian Smartphone Market Share"
	},
	subtitles: [{
		text: "Q2, 2016"
	}],
	data: [{
		type: "pie",
		startAngle: 180,
		toolTipContent: "<b>{label}</b>: {y}%",
		showInLegend: "true",
		legendText: "{label}",
		indexLabel: "{label} - {y}%",
		dataPoints: @Html.Raw(ViewBag.DataPoints)
	}]
});
chart.render();
 
}