mapboxgl.accessToken = "pk.eyJ1IjoibWlya29iaWVuIiwiYSI6ImNqdm80YjJkMDF1Y2s0M3FsM2l5dzF1MnQifQ.Y9bB3T5nLL3mRatNIWIFCA";
var origin = [-71.3733292, -33.0422211, 0];

var map = new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/streets-v10',
    center: origin,
    zoom: 13,
	minzoom: 10,
    pitch: 60,
    bearing: 80
});


map.on('style.load', function() {

    map.addLayer({
        id: 'custom_layer',
        type: 'custom',
        onAdd: function(map, mbxContext){

            tb = new Threebox(
                map, 
                mbxContext,
                {defaultLights: true}
            );

            // initialize geometry and material of our cube object
            var geometry = new THREE.BoxGeometry(200, 200, 200);

            var redMaterial = new THREE.MeshPhongMaterial( {
                color: 0x009900, 
                side: THREE.DoubleSide
            });

            var cube = new THREE.Mesh(geometry, redMaterial);

            cube = tb.Object3D({obj: cube})
                .setCoords(origin)

            //tb.add(cube)

            vectores = new Array();
			var geometria = new Array();
            for(var i = 0; i < 50; i++){
                x = Math.floor(Math.random() * 5000);
                y = Math.floor(Math.random() * 5000);
                z = Math.floor(Math.random() * 1000);
                vec = new THREE.Vector3(x,y,z);
                vectores.push(vec);
				punto = [x,y,z];
				geometria.push(punto);
            } //REEMPLAZAR ESTE METODO PARA RECIBIR LA VARIABLE ENTREGADA POR DJANGO
            //TAMBIEN RECORDAR USAR EL METODO DE THREEBOX.LINE QUE FUNCIONA CON LONGITUD Y LATITUD, PERO NO COORDENADAS SIMPLES

            console.log(vectores);

            var curve = new THREE.CatmullRomCurve3( vectores );

            var curveMaxPoints = 5000;

            //Definición de linea
            var geometry = new THREE.Geometry().setFromPoints(curve.getPoints(curveMaxPoints));
            var length = curve.getPoints(curveMaxPoints).length
            console.log(length);


            var material = new THREE.LineBasicMaterial( { color: 0x0000ff, linewidth: 3  } );
            var linea = new THREE.Line( geometry, material );
            var lineaita = tb.Object3D({obj: linea, units: "meters"}).setCoords(origin).set({rotation: {x:0,y:0,z:0}});
            tb.add(lineaita);
			console.log(geometria);
            //CARGAR AVION
        },
        
        render: function(gl, matrix){
            tb.update();
        }
    });
});