﻿/// <reference path="~/GeneratedArtifacts/viewModel.js" />


myapp.Распоред.Vreme_pocetok_postRender = function (element, contentItem) {
    element.innerHTML = contentItem.value.format("HH:mm");

};
myapp.Распоред.Vreme_kraj_postRender = function (element, contentItem) {
    element.innerHTML = contentItem.value.format("HH:mm");

};