console.log('markers: ' + JSON.stringify(markers));
//console.log('data: ' + JSON.stringify(data));

var map = L.map('map', {
    center: [40.2086, -8.421],//[20.0, 5.0],
    minZoom: 2,
    zoom: 14
});

L.tileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a>',
    subdomains: ['a', 'b', 'c']
}).addTo(map);

var myURL = jQuery('script[src$="leaf.js"]').attr('src').replace('leaf.js', '');

var myIcon = L.icon({
    iconUrl: myURL + 'pin24.png',
    iconRetinaUrl: myURL + 'pin48.png',
    iconSize: [29, 24],
    iconAnchor: [9, 21],
    popupAnchor: [0, -14]
});

//for (var i = 0; i < markers.length; ++i) {
//    L.marker([markers[i].lat, markers[i].lng], { icon: myIcon })
//        .bindPopup('<a href="' + markers[i].url + '" target="_blank">' + markers[i].name + '</a>')
//        .addTo(map);
//}

for (var i = 0; i < markers_data.length; ++i) {
    L.marker([markers_data[i].Lat, markers_data[i].Lng], { icon: myIcon })
        .bindPopup('<a href="' + markers_data[i].Url + '" target="_blank">' + markers_data[i].Name + '</a> <br> <p>' + markers_data[i].Info + '<p>')
        .addTo(map);
}