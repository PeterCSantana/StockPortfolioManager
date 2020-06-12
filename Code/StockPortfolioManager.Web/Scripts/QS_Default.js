$(document).ready(function () {

  InitializeMaterialize();

  SetMaskModal();

  $('.grid-result').on('click', '.rowlink', function () {
    window.location.href = this.dataset.href;
  });

});

function SetMaskModal() {
  //$(".numeric3").mask("000", { reverse: true });
  //$(".CEP").mask("00000-000", { reverse: true });
}

function SendMessage(msg, typ) {
  Materialize.toast(msg, 5000, typ);
}

function InitializeMaterialize() {
  $('.dropdown-trigger').dropdown({
    coverTrigger: false,
    hover: true,
    closeOnClick: false,
    inDuration: 300,
    outDuration: 400
  });

  /* ------ *
  * Tooltip *
  * ------- */
  $('.tooltipped').tooltip({ delay: 50 });

  /* --------------- *
   * Material select *
   * --------------- */
  $('.input-field select').formSelect();

  /* ---------- *
   * Datepicker *
   * ---------- */
  $('.datepicker').datepicker({
    monthsFull: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
    monthsShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
    weekdaysFull: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
    weekdaysShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sab'],

    selectMonths: true, // Creates a dropdown to control month
    selectYears: 15, // Creates a dropdown of 15 years to control year,
    today: 'Hoje',
    clear: 'Limpar',
    close: 'Selecionar',
    closeOnSelect: false, // Close upon selecting a date,
    format: 'dd/mm/yyyy'
  });

  /* ---------- *
  * Timepicker *
  * ---------- */
  $('.timepicker').timepicker({
    default: 'now', // Set default time: 'now', '1:30AM', '16:30'
    fromnow: 0,       // set default time to * milliseconds from now (using with default = 'now')
    twelvehour: false, // Use AM/PM or 24-hour format
    donetext: 'Selecionar', // text for done-button
    cleartext: 'Limpar', // text for clear-button
    canceltext: 'Cancelar', // Text for cancel-button
    autoclose: false, // automatic close timepicker
    ampmclickable: true // make AM PM clickable
  });


  /* ---------- *
   * Slimscroll *
   * ---------- */
  $('.slimscroll').each(function () {
    var jThis = $(this);

    var options = {};
    $.extend(options, jThis.data());

    jThis.slimScroll(options);
  });


  /* ----- *
   * Modal *
   * ----- */
  $('.modal').modal();
}