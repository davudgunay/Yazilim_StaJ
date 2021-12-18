const { error } = require("jquery");

$(document).on("click", "#ktgEkle", async function () {
    const { value: formValues } = await Swal.fire({
        title: 'Kategori Ekle',
        html:
            '<input id="ktgAd" class="swal2-input">',
    })

    if (formValues) {
        var ktgAd = $("#ktgAd").val();
        $.ajax({
            type: 'Post',
            url: '/Kategori/EkleJson',
            data: { "ktgAd": ktgAd },
            dataType: 'Json',
            success: function (data) {
                var ktgId = '<td>' + data.Result.Id + '</td>';
                var ktgAd = '<td>' + data.Result.Ad + '</td>';
                var kitapAdet = "< td > 0</td >";
                var guncelleButon = "<td><button class='guncelle btn btn-custom' value='" + ktgId + "'>Güncelle</button></td>";
                var silButon = "<td><button class='sil btn btn-danger' value='" + ktgId + "'>Sil</button></td>";
                $("#example tbody").prepend('<tr>' + ktgAd + kitapAdet + guncelleButon + silButon + '</tr>');
                Swal.fire({
                    type: 'success',
                    title: 'Kategori Eklendi',
                    text: 'İşlem Başarıyla Gerçekleşti!'
                });
            },
            error: function (){
                Swal.fire({
                    type: 'error',
                    title: 'Kategori Eklenmedi',
                    text: 'Bir Sorun İle Karşılaşıldı!'
                });
            }
        });
    }
});

$(document).on("click", "#guncelle", async function () {

});