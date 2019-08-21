/**
 * Road segment, the smallest road unit to hold one or more cars
 * @param {string} name name of this segment
 * @param {integer} capacity maximum car size units can this segment fit
 * @param {integer} inFlux maximum units of car sizes can get into this road segment
 * @param {integer} outFlux maximum units of car size can leave thsi segment
 */
function Segment(name, capacity, inFlux, outFlux) {
    this.occupancy = 0;
    this.name = name;
    this.capacity = capacity;
    this.inFlux = inFlux;
    this.outFlux = outFlux;
}

/**
 * attempt to fill segment, based on capacity ad flux, if not, reject 
 */
Segment.prototype.fill = function (size) {
    var actualSize = Math.min(this.inFlux,size);
    if(this.occupancy + actualSize <= this.capacity) {
        this.occupancy += actualSize;
        return actualSize;
    } else {
        return 0;
    }
};

/**
 * attempt to drain segment, based on capacity and flux, if not reject 
 */
Segment.prototype.drain = function(size){
    var actualSize = Math.min(this.inFlux,size, this.occupancy);
    this.occupancy -= actualSize;
    return actualSize;
};

module.exports = Segment;